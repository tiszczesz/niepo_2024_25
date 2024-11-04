using System;
using Microsoft.EntityFrameworkCore;

namespace mysql_ef.Models;

public class ShopDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public ShopDbContext(DbContextOptions<ShopDbContext> options) : base(options)
    {
        
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>().HasData(
            new Product
            {
                Id = 1,
                Name = "Product 1",
                Price = 100,
                ProdDate = new DateOnly(2021, 10, 10),
                Category = "Category 1"
            },
            new Product
            {
                Id = 2,
                Name = "Product 2",
                Price = 200,
                ProdDate = new DateOnly(2021, 10, 11),
                Category = "Category 2"
            },
            new Product
            {
                Id = 3,
                Name = "Product 3",
                Price = 300,
                ProdDate = new DateOnly(2021, 10, 12),
                Category = "Category 3"
            }
        );
    }
}
