using System;
using System.Collections.Generic;
using System.Text;

namespace JonathanGraduationBookApp.Core.Model
{
	public class BookModel
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Genre { get; set; }

		//connects too AuthorModel
		public int AuthorId { get; set; }
		public AuthorModel Author { get; set; }

		//connects too PublisherModel
		public int PublisherId { get; set; }
		public PublisherModel Publisher { get; set; }
	}
}
