using System;
using System.Collections.Generic;
using System.Text;

namespace JonathanGraduationBookApp.Core.Model
{
	public class AuthorModel
	{
		public int Id { get; set; }
		public string Author { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public ICollection<BookModel> Books { get; set; }
	}
}
