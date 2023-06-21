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

        public async Task CreateBookAsync(Book book)
        {
            await _dbContext.BookTable.AddAsync(book);
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
    }
}
