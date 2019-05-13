using DontRot.DAL.Entities;
using System.Collections.Generic;

namespace DontRot.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Food> Foods { get; } = new List<Food>();
    }
}
