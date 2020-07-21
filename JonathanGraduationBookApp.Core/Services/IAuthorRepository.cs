using JonathanGraduationBookApp.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace JonathanGraduationBookApp.Core.Services
{
	public interface IAuthorRepository
	{
		AuthorModel Add(AuthorModel author);
		AuthorModel Get(int id);
		IEnumerable<AuthorModel> GetAll();
		AuthorModel Update(AuthorModel author);
		void Remove(int id);
	}
}
