using System;
using System.Collections.Generic;
using System.Text;

namespace DontRot.Bll.Dtos
{
    public class Food
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ExpiryDateTime { get; set; }
        public int Quantity { get; set; }
        public string CategoryName { get; set; }
        public string SlotName { get; set; }
        public string StorageName { get; set; }
    }
}
