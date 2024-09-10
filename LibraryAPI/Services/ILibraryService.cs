using LibraryAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LibraryAPI.Services
{
    public interface ILibraryService
    {
        Task<Book> GetBook(int id);
        Task<IEnumerable<Book>> GetBooks();
        Task AddBook(Book book);
    }
}
