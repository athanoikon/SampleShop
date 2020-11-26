using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace SampleShop.ProductManagement.Models.DatabaseContext
{
    public class SampleShopContext : DbContext
    {
        public SampleShopContext(DbContextOptions<SampleShopContext> options): base (options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().ToTable("Category");
            modelBuilder.Entity<Country>().ToTable("Country");
            modelBuilder.Entity<Currency>().ToTable("Currency");
            modelBuilder.Entity<Flag>().ToTable("Flag");
            modelBuilder.Entity<Product>().ToTable("Product");
            modelBuilder.Entity<PurchaseHistory>().ToTable("PurchaseHistory");
            modelBuilder.Entity<PurchaseHistoryType>().ToTable("PurchaseHistoryType");
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<SubCategory>().ToTable("SubCategory");
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Flag> Flags { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<PurchaseHistory> PurchasesHistory { get; set; }
        public DbSet<PurchaseHistoryType> PurchaseHistoryTypes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }

    }
}
