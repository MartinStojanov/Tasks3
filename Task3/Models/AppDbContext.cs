using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task3.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

       protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed categories
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Pies", Description = "Pies category"});
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Burgers", Description = "Burgers category" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Pizza", Description = "Pizza category" });
            modelBuilder.Entity<Product>().HasData(new Product 
            {
                ProductID = 1,
                ProductName = "Apple Pie",
                SupplierID = 1,
                UnitPrice = 10,
                UnitInStock = 5,
                unitsOnOrder  = 3, 
                CategoryId = 1
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductID = 2,
                ProductName = "Blueberry Cheese Cake",
                SupplierID = 1,
                UnitPrice = 50,
                UnitInStock = 5,
                unitsOnOrder = 3,
                CategoryId = 1
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductID = 3,
                ProductName = "Cheese Cake",
                SupplierID = 1,
                UnitPrice = 70,
                UnitInStock = 10,
                unitsOnOrder = 7,
                CategoryId = 1
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductID = 4,
                ProductName = "Whopper® Cheese",
                SupplierID = 1,
                UnitPrice = 70,
                UnitInStock = 10,
                unitsOnOrder = 7,
                CategoryId = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductID = 5,
                ProductName = "Big King®",
                SupplierID = 1,
                UnitPrice = 100,
                UnitInStock = 10,
                unitsOnOrder = 7,
                CategoryId = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductID = 6,
                ProductName = "Cheeseburger",
                SupplierID = 1,
                UnitPrice = 59,
                UnitInStock = 100,
                unitsOnOrder = 17,
                CategoryId = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductID = 7,
                ProductName = "Pepperoni Pizza",
                SupplierID = 1,
                UnitPrice = 400,
                UnitInStock = 120,
                unitsOnOrder = 57,
                CategoryId = 3
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductID = 8,
                ProductName = "Margherita Pizza",
                SupplierID = 1,
                UnitPrice = 200,
                UnitInStock = 180,
                unitsOnOrder = 95,
                CategoryId = 3
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductID = 9,
                ProductName = "Jumbo Pizza",
                SupplierID = 1,
                UnitPrice = 250,
                UnitInStock = 170,
                unitsOnOrder = 95,
                CategoryId = 3
            });
            
            }
    
}
}
