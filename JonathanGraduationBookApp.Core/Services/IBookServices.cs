﻿using JonathanGraduationBookApp.Core.Model;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace JonathanGraduationBookApp.Core.Services
{
	public interface IBookServices
	{ // CRUDL - create (add), read (get), update, delete (remove), list

		//Create
		BookModel Add(BookModel type);
		
		//Read
		BookModel Get(int id);
		
		//Update
		BookModel Update(BookModel type);
		
		//Delete
		void Remove(BookModel type);
		
		//List
		IEnumerable<BookModel> GetAll();
		IEnumerable<BookModel> GetBooksForAuthor(int id);
	}
}