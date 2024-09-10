using LibraryAPI.Models;
using LibraryAPI.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LibraryAPI.Services
{
    public class LibraryService : ILibraryService
    {
        private readonly ILibraryRepository _libraryRepository;

        public LibraryService(ILibraryRepository libraryRepository)
        {
            _libraryRepository = libraryRepository;
        }

        public async Task<Book> GetBook(int id)
        {
            return await _libraryRepository.GetBook(id);
        }

        public async Task<IEnumerable<Book>> GetBooks()
        {
            return await _libraryRepository.GetBooks();
        }

        public async Task AddBook(Book book)
        {
            await _libraryRepository.AddBook(book);
        }
    }
}
