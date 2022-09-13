using NorthwindLinqEFLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindLinqEFLibrary.Controllers
{
    public class OrderDetailsController
    {
        private readonly AppDbContext _context = null!;
        public OrderDetailsController(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<OrderDetail> GetAllByOrderId()
        {
            return _context.OrderDetails;
        }

        public OrderDetail? GetByPK(int orderId, int productId)
        {
            return _context.OrderDetails.Find(orderId, productId);
        }

        public void Update(int orderId, int productId, OrderDetail orderDetail)
        {
            if (orderId != orderDetail.OrderId || productId != orderDetail.ProductId)
            {
                throw new ArgumentException("Primary Key does not match the instance!");
            }
            _context.Entry(orderDetail).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return;
        }

        public OrderDetail Insert(OrderDetail orderDetail)
        {
            OrderDetail? od = GetByPK(orderDetail.OrderId, orderDetail.ProductId);
            if(od is not null)
            {
                throw new Exception("Product already exists on the order!");
            }
            _context.OrderDetails.Add(orderDetail);
            _context.SaveChanges();
            return orderDetail;
        }

        public void Delete(int orderId, int productId)
        {
            OrderDetail? orderDetail = GetByPK(orderId, productId);
            if(orderDetail is null)
            {
                throw new Exception("OrderDetail not found!");
            }
            _context.Remove(orderDetail);
            _context.SaveChanges();
        }
    }
}
