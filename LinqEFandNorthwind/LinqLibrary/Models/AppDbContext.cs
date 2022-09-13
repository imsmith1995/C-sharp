using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindLinqEFLibrary.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; } = null!;
        public DbSet<Customer> Customers { get; set; } = null!;
        public DbSet<OrderDetail> OrderDetails { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;

        public AppDbContext() { }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            string connStr = @"server=localhost\sqlexpress;" +
                              "database=Northwind;" +
                              "trusted_connection=true;";
            if (!builder.IsConfigured) 
            {
                builder.UseSqlServer(connStr);
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<OrderDetail>(e =>
            {
                e.ToTable("Order Details");
                e.HasKey(x => new { x.OrderId, x.ProductId });
            });
        }
    }
}
