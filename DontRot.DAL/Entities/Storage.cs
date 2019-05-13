using System;
using System.Collections.Generic;
using System.Text;

namespace DontRot.DAL.Entities
{
	public class Storage
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public ICollection<Slot> Slots { get; } = new List<Slot>();
	}
}
