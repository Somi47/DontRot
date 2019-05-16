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
    public class CategoryController : ControllerBase
    {
		public ICategoryService CategoryService { get; }
		public IMapper Mapper { get; }

		public CategoryController( ICategoryService categoryService, IMapper mapper )
		{
			CategoryService = categoryService;
			Mapper = mapper;
		}

		[HttpGet]
		public ActionResult<IEnumerable<Category>> GetAllCategory()
		{
			return Mapper.Map<List<Category>>( CategoryService.GetCategorys() );
		}

		// GET: api/Category/5
		[HttpGet( "{id}" )]
		public ActionResult<Category> GetCategory( int id )
		{
			return Mapper.Map<Category>( CategoryService.GetCategory( id ) );
		}
	}
}