using DontRot.ClientAPI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
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
    }

    public class FoodGrid
    {
        public ObservableCollection<Food> FoodList { get; set; } = new ObservableCollection<Food>();
        public FoodGrid()
        {
        }

        public async void RefreshAsync()
        {
            using (var httpClient = new HttpClient())
            {
                FoodClient foodClient = new FoodClient(httpClient);
                Task<ICollection<Food>> allFoodTask = foodClient.GetAllAsync();
                FoodList.Clear();
                foreach (var item in await allFoodTask)
                {
                    FoodList.Add(item);
                }
            }
        }

        public async void EatOne(Food food)
        {
            --food.Quantity;
            using (var httpClient = new HttpClient())
            {
                FoodClient foodClient = new FoodClient(httpClient);
                await foodClient.PutAsync(food.Id, food);
            }
            RefreshAsync();
        }
    }
}
