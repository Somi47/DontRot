using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DontRot.DAL.Entities
{
	public class Food
	{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
		public string Name { get; set; }
		public DateTime ExpiryDateTime { get; set; }
		public int Quantity { get; set; }
		public int CategoryId { get; set; }
		public Category Category { get; set; }
		public int SlotId { get; set; }
		public Slot Slot { get; set; }
        [ConcurrencyCheck]
        [Column("xmin", TypeName = "xid")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public long RowVersion { get; set; }
    }
}
