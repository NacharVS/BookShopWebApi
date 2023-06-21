using Core;

namespace Application
{
    public interface IBookRepo
    {
        Task<IEnumerable<Book>> GetBooksAsync();

        Task<Book>GetBooksAsync(string id);

        Task CreateBookAsync(Book book);

        void SaveChangesAsync();
    }
}
