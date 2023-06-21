using Application;
using Core;

namespace Infrastructure
{
    internal class ClientRepo : IClientRepo
    {
        public Task<Client> GetClientByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Book>> GetListOfWishesByNameAsync(string name)
        {
            throw new NotImplementedException();
        }
    }
}
