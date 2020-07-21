using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JonathanGraduationBookApp.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace JonathanGraduationBookApp.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class BookController : ControllerBase
	{
		private readonly IBookServices _bookServices;

		public BookController(IBookServices bookServices)
		{
			_bookServices = bookServices;
		}

		//
		[HttpGet]
		public IActionResult Get()
		{
			var 
		}
	}
}
