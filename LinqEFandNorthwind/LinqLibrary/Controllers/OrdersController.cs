using Microsoft.EntityFrameworkCore;
using NorthwindLinqEFLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindLinqEFLibrary.Controllers
{
    public class OrdersController
    {
        private readonly AppDbContext _context = null!;
        public OrdersController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Order>> GetAll()
        {
            return await _context.Orders.ToListAsync();
        }

        public async Task<Order?> GetByPK(int orderId)
        {
            return await _context.Orders.FindAsync(orderId);
        }

        public async Task Update(int orderId, Order order)
        {
            if (orderId != order.OrderId)
            {
                throw new ArgumentException("OrderId does not match the instance of order!");
            }
            _context.Entry(order).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            await _context.SaveChangesAsync();
            return;
        }

        public async Task<Order> Insert(Order order)
        {
            if(order.OrderId != 0)
            {
                throw new ArgumentException("Inserting a new order requires OrderId be set to zero!");
            }
            _context.Orders.Add(order);
            await _context.SaveChangesAsync();
            return order;
        }

        public async Task Delete(int orderId)
        {
            Order? order = await GetByPK(orderId);
            if(order is null)
            {
                throw new Exception("Order not found!");
            }
            _context.Orders.Remove(order);
            await _context.SaveChangesAsync();
        }
    }
}
