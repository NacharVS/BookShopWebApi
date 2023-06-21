using Application;
using Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookShopWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookRepo _bookRepo;

        public BookController(IBookRepo bookRepo)
        {
            _bookRepo = bookRepo;
        }

        [HttpGet("GetAllBooks")]
        public async Task<ActionResult<IEnumerable<Book>>> GetAllBooks()
        {
            var books = await _bookRepo.GetBooksAsync();
            return Ok(books);
        }

        [HttpPost("SendBook")]
        public async Task<ActionResult> SendNewBook(Book book)
        {
           await _bookRepo.CreateBookAsync(book);
            _bookRepo.SaveChangesAsync();
            return Ok();
        }
    }
}
