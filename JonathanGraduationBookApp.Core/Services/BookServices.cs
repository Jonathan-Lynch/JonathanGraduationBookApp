using JonathanGraduationBookApp.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace JonathanGraduationBookApp.Core.Services
{
	class BookServices : IBookServices
	{
		private readonly IBookRepository _bookRepository;
		
		public BookServices(IBookRepository bookRepository)
		{
			_bookRepository = bookRepository;
		}

		public BookModel Add(BookModel newBook)
		{
			return _bookRepository.Add(newBook);
		}

		public BookModel Get(int id)
		{
			return _bookRepository.Get(id);
		}

		public IEnumerable<BookModel> GetAll()
		{
			return _bookRepository.GetAll();
		}

		public IEnumerable<BookModel> GetBooksForAuthor(int id)
		{
			return _bookRepository.GetAll();
		}

		public void Remove(int id)
		{
			_bookRepository.Remove(id);
		}

		public BookModel Update(BookModel updateBook)
		{
			return _bookRepository.Update(updateBook);
		}
	}
}
