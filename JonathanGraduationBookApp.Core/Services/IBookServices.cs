using JonathanGraduationBookApp.Core.Model;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace JonathanGraduationBookApp.Core.Services
{
	public interface IBookServices
	{ // CRUDL - create (add), read (get), update, delete (remove), list

		//Create
		BookModel Add(BookModel newBook);
		
		//Read
		BookModel Get(int id);
		
		//Update
		BookModel Update(BookModel newBook);
		
		//Delete
		void Remove(BookModel newBook);
		
		//List
		IEnumerable<BookModel> GetAll();
		IEnumerable<BookModel> GetBooksForAuthor(int id);
	}
}
