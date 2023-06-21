using Application;
using Core;

namespace Infrastructure
{
    public class BookRepo : IBookRepo
    {
        public Task CreateBookAsync(Book book)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Book>> GetBooksAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Book> GetBooksAsync(string id)
        {
            throw new NotImplementedException();
        }

        public void SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
