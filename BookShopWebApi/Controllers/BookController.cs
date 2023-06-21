using Application;
using AutoMapper;
using BookShopWebApi.DTOs;
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
        private readonly IMapper _bookMapper;

        public BookController(IBookRepo bookRepo, IMapper mapper)
        {
            _bookRepo = bookRepo;
            _bookMapper = mapper;
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

        [HttpPut("UpdateBookById")]
        public IActionResult UpdateBook(int id, BookUpdateDTO updatedBook)
        {
            var bookFromRepo = _bookRepo.GetBooks(id);
            if(bookFromRepo == null)
            {
                return NotFound();  
            }
            else
            {
                _bookMapper.Map(updatedBook, bookFromRepo);
                _bookRepo.UpdateBookById(bookFromRepo);
                _bookRepo.SaveChangesAsync();
                _bookRepo.SaveChangesAsync();
                return Ok();
            }
        }

    }
}
