using System;
using System.Collections.Generic;
using System.Text;

namespace DontRot.DAL.Entities
{
	public class Food
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public DateTime ExpiryDateTime { get; set; }
		public int Quantity { get; set; }
		public int CategoryId { get; set; }
		public Category Category { get; set; }
		public int SlotId { get; set; }
		public Slot Slot { get; set; }
	}
}
