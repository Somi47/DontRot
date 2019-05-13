using System;
using System.Collections.Generic;
using System.Text;

namespace DontRot.Bll.Dtos
{
    public class Slot
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int StorageId { get; set; }
        public Storage Storage { get; set; }
    }
}
