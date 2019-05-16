using DontRot.Bll.Exceptions;
using DontRot.DAL;
using DontRot.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DontRot.Bll.Services
{
	public class CategoryService : ICategoryService
	{
		private readonly DontRotContext _context;

		public CategoryService( DontRotContext context )
		{
			_context = context;
		}

		public Category GetCategory( int CategoryId )
		{
			return _context.Categories
				.SingleOrDefault( c => c.Id == CategoryId ) ?? throw new EntityNotFoundException( "Nem található a rekesz" );
		}

		public IEnumerable<Category> GetCategorys()
		{
			var Categories = _context.Categories
				.ToList();

			return Categories;
		}
	}
}
