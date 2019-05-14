using DontRot.Bll.Exceptions;
using DontRot.DAL;
using DontRot.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DontRot.Bll.Services
{
    public class SlotService : ISlotService
    {
        private readonly DontRotContext _context;

        public SlotService(DontRotContext context)
        {
            _context = context;
        }

        public Slot GetSlot(int SlotId)
        {
            return _context.Slots
                .Include(f => f.Storage)
                .SingleOrDefault(f => f.Id == SlotId) ?? throw new EntityNotFoundException("Nem található a rekesz");
        }

        public IEnumerable<Slot> GetSlots()
        {
            var Slots = _context.Slots
                .Include(f => f.Storage)
                .ToList();

            return Slots;
        }
    }
}
