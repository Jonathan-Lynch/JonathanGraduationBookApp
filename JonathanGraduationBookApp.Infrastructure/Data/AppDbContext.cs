using JonathanGraduationBookApp.Core.Model;
using Microsoft.EntityFrameworkCore;

namespace JonathanGraduationBookApp.Infrastructure.Data
{
	public class AppDbContext : DbContext
	{
		public DbSet<BookModel> Books { get; set; }
		public DbSet<AuthorModel> Authors { get; set; }

		// This method runs once when the DbContext is first used.
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlite("Data Source=books.db");
		}

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);
			//builder.Entity<AuthorModel>().HasData(
			//	 new AuthorModel { Id = 1, FirstName = "John", LastName = "Steinbeck" },
			//	 new AuthorModel { Id = 2, FirstName = "Stephen", LastName = "King" }
			//	);
		}

	}
}
