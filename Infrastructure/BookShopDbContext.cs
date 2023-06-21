using Core;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class BookShopDbContext : DbContext 
    {
        public BookShopDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Book> BookTable { get; set; }

        public DbSet<Client> ClientTable { get; set; }

    }
}
