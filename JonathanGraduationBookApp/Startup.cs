using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JonathanGraduationBookApp.Core.Model;
using JonathanGraduationBookApp.Core.Services;
using JonathanGraduationBookApp.Infrastructure.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace JonathanGraduationBookApp
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
			//services.AddDbContext<AppDbContext>(options => options.UseSqlite("Data Source = books.db"));

			services.AddDbContext<AppDbContext>();

			services.AddScoped<IBookRepository, BookRepository>();
			services.AddScoped<IAuthorRepository, AuthorRepository>();
			services.AddScoped<IBookServices, BookServices>();
			services.AddScoped<IAuthorServices, AuthorServices>();

		}


		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}

			app.UseHttpsRedirection();
			app.UseMvc();
		}
	}
}
