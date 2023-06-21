using Core;

namespace Application
{
    public interface IClientRepo
    {
        Task<IEnumerable<Client>> GetClients();
        Task<Client> GetClientByIdAsync(int id);
        Task CreateClientAsync(Client client);
        Task<IEnumerable<Book>> GetListOfWishesByNameAsync(string name);

        void SaveChanges();
    }
}
