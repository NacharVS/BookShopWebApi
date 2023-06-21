using Application;
using Core;

namespace Infrastructure
{
    internal class ClientRepo : IClientRepo
    {
        public Task<Client> CreateClientAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Client> GetClientByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Book>> GetListOfWishesByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
