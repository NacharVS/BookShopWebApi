using Application;
using Core;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class BookRepo : IBookRepo
    {
        private readonly BookShopDbContext _dbContext;

        public BookRepo(BookShopDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task CreateBook(Book book)
        {
            throw new NotImplementedException();
        }

        public async Task CreateBookAsync(Book book)
        {
            await _dbContext.BookTable.AddAsync(book);
        }

        public async Task<Book> CreateBookAsyncTest(Book bookToSend)
        {
            var book = await _dbContext.BookTable.AddAsync(bookToSend);
            return book.Entity;
        }

        public void DeleteBookAsync(Book book)
        {
           _dbContext.BookTable.Remove(book);
        }

        public Book GetBooks(int id)
        {
            return _dbContext.BookTable.Find(id);
        }

        public async Task<IEnumerable<Book>> GetBooksAsync() => await _dbContext.BookTable.ToListAsync();

        public async Task<Book> GetBooksAsync(int id)
        {
            return await _dbContext.BookTable.FirstAsync(x => x.Id == id);
        }

        public void SaveChangesAsync()
        {
            _dbContext.SaveChanges();
        }

        public void UpdateBookById(Book book)
        {
            _dbContext.BookTable.Update(book);
        }

        public void UpdateBookById(int id, Book book)
        {
            throw new NotImplementedException();
        }

        public void UpdateBookByIdAsync(int id, Book book)
        {
            throw new NotImplementedException();
        }
    }
}
