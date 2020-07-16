using System;
using System.Collections.Generic;
using System.Text;
using JonathanGraduationBookApp.Core.Model;

namespace JonathanGraduationBookApp.Core.Services
{
	interface IBookRepository
	{
		BookModel Add(BookModel book);
		BookModel Update(BookModel book);
		BookModel Get(int id);
		IEnumerable<BookModel> GetAll();
		void Remove(int id);
	}
}
