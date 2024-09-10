using LibraryAPI.Models;
using LibraryAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace LibraryAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LibraryController : ControllerBase
    {
        private readonly ILibraryService _libraryService;

        public LibraryController(ILibraryService libraryService)
        {
            _libraryService = libraryService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBook(int id)
        {
            var book = await _libraryService.GetBook(id);
            if (book == null)
            {
                return NotFound();
            }
            return Ok(book);
        }

        [HttpGet]
        public async Task<IActionResult> GetBooks()
        {
            var books = await _libraryService.GetBooks();
            return Ok(books);
        }

        [HttpPost]
        public async Task<IActionResult> AddBook(Book book)
        {
            if (book == null)
            {
                return BadRequest();
            }
            await _libraryService.AddBook(book);
            return CreatedAtAction(nameof(GetBook), new { id = book.Id }, book);
        }
    }
}
