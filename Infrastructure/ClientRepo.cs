using Application;
using Core;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class ClientRepo : IClientRepo
    {
        private readonly BookShopDbContext _dbContext;

        public ClientRepo(BookShopDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task CreateClientAsync(Client client)
        {
            await _dbContext.ClientTable.AddAsync(client);
        }

        public async Task<Client> GetClientByIdAsync(int id)
        {
            return await _dbContext.ClientTable.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<Client>> GetClients() => await _dbContext.ClientTable.ToListAsync();



        public async Task<IEnumerable<Book>> GetListOfWishesByNameAsync(string name)
        {
            var list =  await _dbContext.ClientTable.FirstOrDefaultAsync<Client>(x=>x.Name == name);
            return list.ListOfWishes;
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }
    }
}
