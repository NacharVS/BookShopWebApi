using Core;

namespace Application
{
    public interface IClientRepo
    {
        Task<Client> GetClientByIdAsync(int id);
        Task<IEnumerable<Book>> GetListOfWishesByNameAsync(string name);
    }
}
