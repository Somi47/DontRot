using DontRot.DAL.Entities;
using System.Collections.Generic;

namespace DontRot.Bll.Services
{
    public interface IFoodService
    {
        Food GetFood(int FoodId);
        IEnumerable<Food> GetFoods();
        Food InsertFood(Food newFood);
        void UpdateFood(int FoodId, Food updatedFood);
        void DeleteFood(int FoodId);
    }
}