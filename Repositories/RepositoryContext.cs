using Microsoft.EntityFrameworkCore;
using Entities.Models;
namespace Repositories
{
    public class RepositoryContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductId = 1,
                    ProductName = "Product 1",
                    Price = 100
                },
                new Product
                {
                    ProductId = 2,
                    ProductName = "Product 2",
                    Price = 200
                },
                new Product
                {
                    ProductId = 3,
                    ProductName = "Product 3",
                    Price = 300
                }
            );

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    CategoryId = 1,
                    CategoryName = "Book"
                },
                new Category
                {
                    CategoryId = 2,
                    CategoryName = "Electronic"
                }
            );
        }
    }
}
