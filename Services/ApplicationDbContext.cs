using crudmvc.Models;
using Microsoft.EntityFrameworkCore;

namespace crudmvc.Services
{
    public class ApplicationDbContext : DbContext
    
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }

    }
}
