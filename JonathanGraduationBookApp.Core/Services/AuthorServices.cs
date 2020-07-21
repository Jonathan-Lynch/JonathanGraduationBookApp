using JonathanGraduationBookApp.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace JonathanGraduationBookApp.Core.Services
{
	class AuthorServices : IAuthorServices
	{
		private readonly IAuthorServices _authorServices;
		public AuthorServices(IAuthorServices authorServices)
		{
			_authorServices = authorServices;
		}

		public AuthorModel Add(AuthorModel newAuthor)
		{
			return _authorServices.Add(newAuthor);
		}

		public AuthorModel Get(int id)
		{
			return _authorServices.Get(id);
		}

		public IEnumerable<AuthorModel> GetAll()
		{
			return _authorServices.GetAll();
		}

		public void Remove(int id)
		{
			_authorServices.Remove(id);
		}

		public AuthorModel Update(AuthorModel updateAuthor)
		{
			return _authorServices.Update(updateAuthor);
		}
	}
}
