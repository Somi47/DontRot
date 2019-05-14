using DontRot.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DontRot.Bll.Services
{
    public interface ISlotService
    {
        Slot GetSlot(int SlotId);
        IEnumerable<Slot> GetSlots();
    }
}
