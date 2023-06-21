using Core;

namespace Application
{
    public interface IClientRepo
    {
        Task<Client> GetClientByIdAsync(int id);
        Task<Client> CreateClientAsync();
        Task<IEnumerable<Book>> GetListOfWishesByNameAsync(string name);

        void SaveChanges();
    }
}
