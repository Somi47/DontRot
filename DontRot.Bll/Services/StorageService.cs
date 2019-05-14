using DontRot.Bll.Exceptions;
using DontRot.DAL;
using DontRot.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DontRot.Bll.Services
{
    public class StorageService : IStorageService
    {
        private readonly DontRotContext _context;

        public StorageService(DontRotContext context)
        {
            _context = context;
        }

        public Storage GetStorage(int StorageId)
        {
            return _context.Storages
                .SingleOrDefault(f => f.Id == StorageId) ?? throw new EntityNotFoundException("Nem található a rekesz");
        }

        public IEnumerable<Storage> GetStorages()
        {
            var Storages = _context.Storages
                .ToList();

            return Storages;
        }
    }
}
