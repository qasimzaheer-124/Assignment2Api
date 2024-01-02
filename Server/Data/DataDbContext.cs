using Assignment2Api.Shared;
using Microsoft.EntityFrameworkCore;

namespace Assignment2Api.Server.Data
{
    public class DataDbContext : DbContext
    {
        public DataDbContext(DbContextOptions<DataDbContext> options) : base(options)
        {
        }
        public DbSet<User> users { get; set; }
        public DbSet<Product> products { get; set; }
    }
}
