using Microsoft.EntityFrameworkCore;
using Shop.Core.Entities;
using Shop.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly DataContext _context;
        public ProductRepository(DataContext context)
        {
            _context = context;
        }


        public List<Product> GetList()
        {
            if (_context.Products.ToList().Count == 0)
                Console.WriteLine("there is'nt products");
            return _context.Products.Include(p=>p.Orders).ToList();
        }
        public Product GetProductById(int productId)
        {
            Product p = _context.Products.ToList().Find(item => item.Id == productId);
            if (p == null)
            {
                Console.WriteLine($"the id:{productId} is not exist");
            }
            return p;
        }
        public bool AddProduct(Product product)
        {
            Product p = new Product() {Name=product.Name,Price=product.Price,Amount=product.Amount,Description=product.Description };
            _context.Products.Add(product);
            _context.SaveChanges();
            return true;
        }
        public void UpdateAmount(int productId, int numNews)
        {
            Product p = _context.Products.ToList().Find(item => item.Id == productId);
            if (p != null)
            {
                p.Amount += numNews;
                if (p.Amount > 0)
                {
                    p.IsExist = true;
                }
                else
                {
                    p.IsExist = false;
                }
                _context.SaveChanges();
            }
            else
            {
                Console.WriteLine("there is'nt such a product");
            }
        }
        public void UpdatePrice(int productId, double newPrice)
        {
            Product p = _context.Products.ToList().Find(item => item.Id == productId);
            if (p != null)
            {
                p.Price = newPrice;
                _context.SaveChanges();
            }
            else
            {
                Console.WriteLine($"this id:{productId} is'nt exist");
            }
        }
        public void DeleteProduct(int productId)
        {
            Product p = _context.Products.ToList().Find(item => item.Id == productId);
            if (p != null)
            {
                p.Amount = 0;
                p.IsExist = false;
                _context.SaveChanges();
            }
            else
            {
                Console.WriteLine($"this id:{productId} is'nt exist");
            }
        }
    }
}
