using LibraryAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LibraryAPI.Repositories
{
    public interface ILibraryRepository
    {
        Task<Book> GetBook(int id);
        Task<IEnumerable<Book>> GetBooks();
        Task AddBook(Book book);
        Task UpdateBook(Book book);
        Task DeleteBook(int id);
    }
}
