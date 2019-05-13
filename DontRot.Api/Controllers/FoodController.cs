using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DontRot.Bll.Services;
using AutoMapper;
using DontRot.Bll.Dtos;

namespace DontRot.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodController : ControllerBase
    {
        public IFoodService FoodService { get; }
        public IMapper Mapper { get; }

        public FoodController(IFoodService foodService, IMapper mapper)
        {
            FoodService = foodService;
            Mapper = mapper;
        }

		[HttpGet]
        public IEnumerable<Food> Get()
        {
            return Mapper.Map<List<Food>>( FoodService.GetFoods() );
        }

        // GET: api/Food/5
        [HttpGet("{id}", Name = "Get")]
        public Food Get(int id)
        {
            return Mapper.Map<Food>(FoodService.GetFood(id));
        }

        // POST: api/Food
        [HttpPost]
        public void Post([FromBody] Food value)
        {

        }

        // PUT: api/Food/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
