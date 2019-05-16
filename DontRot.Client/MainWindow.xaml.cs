using DontRot.ClientAPI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DontRot.Client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public FoodGrid FoodGrid { get; }
        public MainWindow()
        {
            InitializeComponent();
            FoodGrid = new FoodGrid();
            this.DataContext = FoodGrid;
            FoodGrid.RefreshAsync();
        }

        private void Button_Click_Refresh(object sender, RoutedEventArgs e)
        {
            FoodGrid.RefreshAsync();
        }
        private void Button_Click_EatOne(object sender, RoutedEventArgs e)
        {
            ListView listView = (ListView)FindName("lvFood");
            if (listView.SelectedItem == null)
                return;

            FoodGrid.EatOne((Food)listView.SelectedItem);
        }
        private void Button_Click_EatAll( object sender, RoutedEventArgs e )
        {
            ListView listView = (ListView)FindName( "lvFood" );
            if( listView.SelectedItem == null )
                return;

            FoodGrid.EatAll( (Food)listView.SelectedItem );
        }
        private void Storage_SelectionChanged(object sender, RoutedEventArgs e)
        {
            ComboBox cmb = sender as ComboBox;
            FoodGrid.FilterSlots( (Storage)cmb.SelectedItem );
        }
    }

    public class FoodGrid
    {
        public DateTime Expiry { get; set; } = DateTime.Now;
        public string Quantity { get; set; } = "1";
        public ObservableCollection<Food> FoodList { get; set; } = new ObservableCollection<Food>();
        public ObservableCollection<Category> CategoryList { get; set; } = new ObservableCollection<Category>();
        public ObservableCollection<Storage> StorageList { get; set; } = new ObservableCollection<Storage>();
        public ObservableCollection<Slot> SlotList { get; set; } = new ObservableCollection<Slot>();
        public ObservableCollection<Slot> FilteredSlotList { get; set; } = new ObservableCollection<Slot>();
        public FoodGrid()
        {
        }

        public async void RefreshAsync()
        {
            while( true )
            {
                try
                {
                    using( var httpClient = new HttpClient() )
                    {
                        FoodClient foodClient = new FoodClient( httpClient );
                        Task<ICollection<Food>> allFoodTask = foodClient.GetAllFoodAsync();
                        FoodList.Clear();
                        foreach( var item in await allFoodTask )
                        {
                            FoodList.Add( item );
                        }

                        CategoryClient categoryClient = new CategoryClient( httpClient );
                        Task<ICollection<Category>> allCategoryTask = categoryClient.GetAllCategoryAsync();
                        CategoryList.Clear();
                        foreach( var item in await allCategoryTask )
                        {
                            CategoryList.Add( item );
                        }

                        StorageClient storageClient = new StorageClient( httpClient );
                        Task<ICollection<Storage>> allStorageTask = storageClient.GetAllStorageAsync();
                        StorageList.Clear();
                        foreach( var item in await allStorageTask )
                        {
                            StorageList.Add( item );
                        }

                        SlotClient slotClient = new SlotClient( httpClient );
                        Task<ICollection<Slot>> allSlotTask = slotClient.GetAllSlotAsync();
                        SlotList.Clear();
                        foreach( var item in await allSlotTask )
                        {
                            SlotList.Add( item );
                        }
                    }
                    return;
                }
                catch
                {
                    Thread.Sleep( 500 );
                }
            }
        }

        public void FilterSlots( Storage storage )
        {
            FilteredSlotList.Clear();
            foreach( var item in SlotList)
            {
                if( item.Storage.Id == storage.Id )
                    FilteredSlotList.Add( item );
            }
        }

        public async void EatOne(Food food)
        {
            --food.Quantity;
            using (var httpClient = new HttpClient())
            {
                FoodClient foodClient = new FoodClient(httpClient);
                await foodClient.PutFoodAsync(food.Id, food);
            }
            RefreshAsync();
        }

        public async void EatAll( Food food )
        {
            using( var httpClient = new HttpClient() )
            {
                FoodClient foodClient = new FoodClient( httpClient );
                await foodClient.DeleteFoodAsync( food.Id );
            }
            RefreshAsync();
        }
    }
}
