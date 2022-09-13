using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindLinq.Models
{
    public class NorthwindContext : DbContext
    {

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        public NorthwindContext() { }  //only need this constructor for ConsoleApps
        public NorthwindContext(DbContextOptions<NorthwindContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            string connectionString = @"server = localhost\sqlexpress;" +
                                        "database=Northwind;" +
                                        "trusted_connection=true;";
            if (!builder.IsConfigured)
            {
                builder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder builder) 
        {
            builder.Entity<OrderDetail>(p => 
            {
                p.HasKey(x => new { x.OrderId, x.ProductId });
            });
        }
    }
}
