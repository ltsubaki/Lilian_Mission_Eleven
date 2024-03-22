using System.Diagnostics;
using Lilian_Mission_Eleven.Models;
using Lilian_Mission_Eleven.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Lilian_Mission_Eleven.Controllers
{
	public class HomeController : Controller
	{
		private IBookRepository _repo;
		public HomeController(IBookRepository temp)
		{
			_repo = temp;
		}

		public IActionResult Index(int pageNum)
		{
			int pageSize = 10;

			//Bundling up multiple models to pass!
			var blah = new BookListViewModel
			{

				Books = _repo.Books
					.OrderBy(x => x.Title)
					.Skip((pageNum - 1) * pageSize)
					.Take(pageSize),

				PaginationInfo = new PaginationInfo
				{
					CurrentPage = pageNum,
					ItemsPerPage = pageSize,
					TotalItems = _repo.Books.Count()
				}
			};

			return View(blah);
		}

		public IActionResult Surprise()
		{
			return View();
		}
	}
}
