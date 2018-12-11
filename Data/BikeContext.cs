using BikeShop.Models;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeShop.Data
{
    public class BikeContext: DbContext
    {
        public BikeContext (DbContextOptions<BikeContext> options) : base(options) { }

        public DbSet<Category> Category { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Product_Customer> Joint { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
         
            modelBuilder.Entity<Models.Product_Customer>()
                .HasKey(PC => new { PC.ProductId, PC.CustomerId });

            modelBuilder.Entity<Models.Product_Customer>()
                .HasOne(PC => PC._customer)
                .WithMany(P => P.ProductList)
                .HasForeignKey(PC => PC.CustomerId);

            modelBuilder.Entity<Models.Product_Customer>()
                .HasOne(PC => PC._product)
                .WithMany(C => C.CustomerList)
                .HasForeignKey(PC => PC.ProductId);
        }

    }
    
    
}
