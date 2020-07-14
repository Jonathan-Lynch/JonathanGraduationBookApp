using System;
using System.Collections.Generic;
using System.Text;

namespace JonathanGraduationBookApp.Core.Model
{
	public class PublisherModel
	{
		public int Id { get; set; }
		public string Publisher { get; set; }
		public string Name { get; set; }
		public ICollection<BookModel> Books { get; set; }
	}
}
