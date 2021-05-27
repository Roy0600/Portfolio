using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Themaweek7.Entities
{
    class ProductsDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb; Database = ProductDb;"
                + "Trusted_Connection=True;");
        }
    }
}