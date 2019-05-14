using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DontRot.Bll.Dtos;
using DontRot.Bll.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DontRot.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StorageController : ControllerBase
    {
        public IStorageService StorageService { get; }
        public IMapper Mapper { get; }

        public StorageController(IStorageService storageService, IMapper mapper)
        {
            StorageService = storageService;
            Mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Storage>> Get()
        {
            return Mapper.Map<List<Storage>>(StorageService.GetStorages());
        }

        // GET: api/Storage/5
        [HttpGet("{id}", Name = "Get")]
        public ActionResult<Storage> Get(int id)
        {
            return Mapper.Map<Storage>(StorageService.GetStorage(id));
        }
    }
}