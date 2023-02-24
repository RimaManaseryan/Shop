using Microsoft.EntityFrameworkCore;
using Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class ShopContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<SalesOrders> SalesOrders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=Vardan;Database=Shop; User Id=sa;password=123456789;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>(e =>
            {
                e.HasKey(s => s.ItemCode);
                e.Property(s => s.ItemCode).HasColumnType("NVARCHAR(20)").HasColumnName("ItemCode");
                e.Property(s => s.Description).HasColumnName("Description").HasColumnType("NVARCHAR(50");
                e.Property(s => s.ItemType).HasColumnType("NVARCHAR(20)").HasColumnName("ItemType");
                e.Property(s => s.Cost).HasColumnName("Cost").HasColumnType("int");
                e.Property(s => s.Price).HasColumnType("int").HasColumnName("Price");
                e.Property(s => s.Quantity).HasColumnName("Quantity").HasColumnType("int");
            });
            modelBuilder.Entity<Customer>(e =>
            {
                e.HasKey(s => s.CustomerName);
                e.Property(s => s.CustomerName).HasColumnType("NVARCHAR(20)").HasColumnName("CustomerName");
                e.Property(s => s.Phone).HasColumnName("Phone").HasColumnType("NVARCHAR(12)");
                e.Property(s => s.Address1).HasColumnType("NVARCHAR(50)").HasColumnName("Address1");
                e.Property(s => s.Address2).HasColumnName("Address2").HasColumnType("NVARCHAR(50)");
                e.Property(s => s.Status).HasColumnType("NVARCHAR(20)").HasColumnName("Status");
                e.Property(s => s.CreditLimit).HasColumnName("CreditLimit").HasColumnType("NVARCHAR(20)");
            });
            modelBuilder.Entity<SalesOrders>(e =>
            {
                e.HasKey(s => s.OrderNbr);
                e.Property(s => s.OrderNbr).HasColumnType("int").HasColumnName("OrderNbr");
                e.Property(s => s.CustomerName).HasColumnName("Customer").HasColumnType("NVARCHAR(20)");
                e.Property(s => s.date).HasColumnName("Date").HasColumnType("DATE");
                e.Property(s => s.Address).HasColumnType("NVARCHAR(50)").HasColumnName("Address");
                e.Property(s => s.ItemCode).HasColumnName("ItemCode").HasColumnType("NVARCHAR(20)");
                e.Property(s => s.Description).HasColumnType("NVARCHAR(50)").HasColumnName("Description");
                e.Property(s => s.Quantity).HasColumnName("Quantitiy").HasColumnType("int");
                e.Property(s => s.Price).HasColumnType("int").HasColumnName("Price");
                e.Property(s => s.Amount).HasColumnName("Amount").HasColumnType("int");
            });
        }

    }
}
