using System;
using System.Collections.Generic;
using System.Text;
using JonathanGraduationBookApp.Core.Model;
using Microsoft.EntityFrameworkCore;	

namespace JonathanGraduationBookApp.Infrastructure.Data
{
	public class AppDbContext : DbContext
	{
		public DbSet<BookModel> Books { get; set; }
		public DbSet<AuthorModel> Authors { get; set; }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);
		}
	}
}
