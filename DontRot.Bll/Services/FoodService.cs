using System.Collections.Generic;
using System.Linq;
using DontRot.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using DontRot.Bll.Exceptions;
using DontRot.DAL;

namespace DontRot.Bll.Services
{
    public class FoodService : IFoodService
    {
        private readonly DontRotContext _context;

        public FoodService(DontRotContext context)
        {
            _context = context;
        }

        public Food GetFood(int FoodId)
        {
            return _context.Foods
                .Include(f => f.Category)
                .Include(f => f.Slot)
                    .ThenInclude(s => s.Storage)
                .SingleOrDefault(f => f.Id == FoodId) ?? throw new EntityNotFoundException("Nem található az étel");
        }

        public IEnumerable<Food> GetFoods()
        {
            var Foods = _context.Foods
				.Include(f => f.Category)
				.Include(f => f.Slot)
					.ThenInclude(s => s.Storage)
				.ToList();

            return Foods;
        }

        public Food InsertFood(Food newFood)
        {
            _context.Foods.Add(newFood);

            _context.SaveChanges();

            return newFood;
        }

        public void UpdateFood(int FoodId, Food updatedFood)
        {
            updatedFood.Id = FoodId;
            var entry = _context.Attach(updatedFood);
            entry.State = EntityState.Modified;
            _context.SaveChanges();           
        }

        public void DeleteFood(int FoodId)
        {
            _context.Foods.Remove(new Food { Id = FoodId });
            _context.SaveChanges();            
        }
    }
}
