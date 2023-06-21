using Core;

namespace Application
{
    public interface IBookRepo
    {
        Task<IEnumerable<Book>> GetBooksAsync();

         Book GetBooks(int id);

        void UpdateBookById(Book book);

        Task CreateBookAsync(Book book);
        void DeleteBookAsync(Book book);
        void SaveChangesAsync();
    }
}
