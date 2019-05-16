using DontRot.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DontRot.Bll.Services
{
	public interface ICategoryService
	{
		Category GetCategory( int CategoryId );
		IEnumerable<Category> GetCategorys();
	}
}
