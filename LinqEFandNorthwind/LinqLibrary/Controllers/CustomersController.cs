using Microsoft.EntityFrameworkCore;
using NorthwindLinqEFLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindLinqEFLibrary.Controllers
{
    public class CustomersController
    {
        private readonly AppDbContext _context = null!;
        public CustomersController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Customer>> GetAll()
        {
            return await _context.Customers.OrderBy(c => c.CompanyName).ToListAsync();
        } 

        public async Task<Customer?> GetByPK(string customerId)
        {
            return await _context.Customers.FindAsync(customerId);
        }

        public async Task Update(string customerId, Customer customer)
        {
            if (customerId != customer.CustomerId)
            {
                throw new ArgumentException("Customer ID does not match customer instance!");
            }
            _context.Entry(customer).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            //Above line of code is forcing EnitityFramework to recognize the entry as a modified entry.
            //Thus you can use .SaveChanges() to save all changes.
            await _context.SaveChangesAsync();
            return;
        }

        public async Task<Customer> Insert(Customer customer)
        {
            if (customer.CustomerId.Length != 5)
            {
                throw new ArgumentException("Inserting a new customer requires the CustomerId be set!");
            }
            else if (customer.CompanyName is null)
            {
                throw new ArgumentException("Insertng a new customer requires the CompanyName be set!");
            }
            _context.Customers.Add(customer);
            await _context.SaveChangesAsync();
            return customer;
        }  

        public async Task Delete(string customerId)
        {
            Customer? cust = await GetByPK(customerId);
            if (cust is null)
            {
                throw new Exception("Customer not found!");
            }
            _context.Customers.Remove(cust);
            await _context.SaveChangesAsync();
        }
    }
}
