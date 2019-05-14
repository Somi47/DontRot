using DontRot.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DontRot.Bll.Services
{
    public interface IStorageService
    {
        Storage GetStorage(int StorageId);
        IEnumerable<Storage> GetStorages();
    }
}
