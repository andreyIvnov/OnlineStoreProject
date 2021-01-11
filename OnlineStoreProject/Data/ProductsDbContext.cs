using Microsoft.EntityFrameworkCore;
using OnlineStoreProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStoreProject.Data
{
    public class ProductsDbContext : DbContext
    {
        public ProductsDbContext(DbContextOptions<ProductsDbContext> options) : base(options)
        {

        }



        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ID = 1,
                    Name = "Woter Dragon",
                    Price = 60_00000,
                    Description = "Big strong, but have no left eye",
                    QuantityInStoke = 3,
                    Image = "https://friendlystock.com/wp-content/uploads/2018/05/6-blue-dragon-cartoon-clipart.jpg"
                },
                new Product
                {
                    ID = 2,
                    Name = "Dwarf",
                    Price = 50_000,
                    Description = "Small, but magical",
                    QuantityInStoke = 53,
                    Image = "https://i.pinimg.com/originals/8f/99/83/8f99839632c9f2083b9a0592f5862a46.png"
                });
        }

    }
}
