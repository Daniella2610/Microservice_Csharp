using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using First_microservice_Csharp.Models;
using Microsoft.EntityFrameworkCore;


namespace First_microservice_Csharp.DBContexts
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<CatalogItem> Catalogs { get; set; }
       protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CatalogItem>().HasData(
               new CatalogItem
               {
                   CatagoryId = 1,
                   Name = "Electronics",
                   Description = "Electronic Items",
               },
               new CatalogItem
               {
                   CatagoryId = 2,
                   Name = "Clothes",
                   Description = "Dresses",
               },
               new CatalogItem
               {
                   CatagoryId = 3,
                   Name = "Grocery",
                   Description = "Grocery Items",
               }
           );
        }
    }
}
