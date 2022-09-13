using NorthwindLinqEFLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindLinqEFLibrary.Controllers
{
    public class ProductsController
    {
        private readonly AppDbContext _context = null!;
        public ProductsController(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetAll()
        {
            return _context.Products;
        }

        public Product? GetByPK(int prodId)
        {
            return _context.Products.Find(prodId);
        }

        public void Update(int prodId, Product product)
        {
            if (prodId != product.ProductId)
            {
                throw new ArgumentException("ProductId does not match the instance of product!");
            }
            _context.Entry(prodId).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return;
        }

        public Product Insert(Product product)
        {
            if(product.ProductId != 0)
            {
                throw new Exception("Inserting a new product requires the ProductId be set to zero!");
            }
            _context.Products.Add(product);
            _context.SaveChanges();
            return product;
        }

        public void Delete(int prodId)
        {
            Product? productToBeDeleted = GetByPK(prodId);
            if(productToBeDeleted is null)
            {
                throw new Exception("Product not found!");
            }
            _context.Products.Remove(productToBeDeleted);
            _context.SaveChanges();
        }
    }
}
