using JonathanGraduationBookApp.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace JonathanGraduationBookApp.Core.Services
{
	public interface IAuthorServices
	{// CRUDL - create (add), read (get), update, delete (remove), list

		//Create
		AuthorModel Add(AuthorModel newAuthor);
		
		//Read
		AuthorModel Get(int id);
		
		//Update
		AuthorModel Update(AuthorModel newAuthor);
		
		//Delete
		void Remove(int id);
		
		IEnumerable<AuthorModel> GetAll();
	}
}
