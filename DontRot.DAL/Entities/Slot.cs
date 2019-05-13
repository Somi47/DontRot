using System;
using System.Collections.Generic;
using System.Text;

namespace DontRot.DAL.Entities
{
	public class Slot
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int StorageId { get; set; }
		public Storage Storage { get; set; }
		public ICollection<Food> Foods { get; } = new List<Food>();
	}
}
