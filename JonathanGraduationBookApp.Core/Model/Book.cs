﻿using System;
using System.Collections.Generic;
using System.Text;

namespace JonathanGraduationBookApp.Core.Model
{
	public class Book
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Genre { get; set; }

		//connects too AuthorModel
		public int AuthorId { get; set; }
		public Author Author { get; set; }

	}
}