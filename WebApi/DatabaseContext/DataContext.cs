using Microsoft.EntityFrameworkCore;
using WebApi.Model;

namespace WebApi.DatabaseContext
{
    public class DataContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "ProductDb");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }

        public DbSet<Order> Orders { get; set; }
    }
}
