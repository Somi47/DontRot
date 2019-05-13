﻿using System;
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
        public ActionResult<IEnumerable<Food>> Get()
        {
            return Mapper.Map<List<Food>>( FoodService.GetFoods() );
        }

        // GET: api/Food/5
        [HttpGet("{id}", Name = "Get")]
        public ActionResult<Food> Get(int id)
        {
            return Mapper.Map<Food>(FoodService.GetFood(id));
        }

        // POST: api/Food
        [HttpPost]
        public ActionResult<Food> Post([FromBody] Food food)
        {
            var created = FoodService.InsertFood(Mapper.Map<DAL.Entities.Food>(food));
            return CreatedAtAction(
                        nameof(Get),
                        new { id = created.Id },
                        Mapper.Map<Food>(created)
            );
        }

        // PUT: api/Food/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Food food)
        {
            FoodService.UpdateFood(id, Mapper.Map<DAL.Entities.Food>(food));
            return NoContent();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            FoodService.DeleteFood(id);
            return NoContent();
        }
    }
}
