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
    public class BuyingRepository:IBuyingRepository
    {
        private readonly DataContext _context;
        public BuyingRepository(DataContext context)
        {
            _context = context;
        }
        public Order GetBuying(int orderId)
        {
            Order o = _context.Orders.Include(order=>order.AllProducts).Include(order=>order.Customer).FirstOrDefault(ord => ord.Id == orderId);
            return o;
        }
        public bool AddProductBuy(int productId, int orderId)//add a product to the order
        {
            Order o = _context.Orders.Include(o=>o.AllProducts).ToList().Find(item => item.Id == orderId);
            if (o == null)
            {
                Console.WriteLine("there is'nt such order");
               
            }
            else
            {
                Product p = _context.Products.Include(p=>p.Orders).ToList().Find(prod => prod.Id == productId);
                if (p != null)
                {
                    if (p.Amount > 0)
                    {
                        o.AllProducts.Add(p);
                        p.Amount--;

                        o.SumBuying += p.Price;
                        p.Orders.Add(o);
                        _context.SaveChanges();
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("the product finished");
                    }
                }
                else
                {
                    Console.WriteLine("mistake in the product you sent!");
                }
            }
            
            return false;
        }
        public bool AddAmountBuy(int productId, int orderId)//add amount to an exists product
        {
            Order o = _context.Orders.Include(order=>order.AllProducts).ToList().Find(item => item.Id == orderId);
            if (o != null)
            {
                Product product = _context.Products.ToList().Find(item => item.Id == productId);
                if (product != null)
                {
                    if (product.Amount > 0)
                    {

                        o.AllProducts.Add(product);
                        o.SumBuying += product.Price;
                        product.Amount--;
                        _context.SaveChanges();
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("finish");
                    }
                }
                else
                {
                    Console.WriteLine("there is'nt such a product");
                }
            }
            else
            {
                Console.WriteLine("there is'nt such an order");
            }
            return false ;
        }

        public bool DeleteProductBuy(int productId, int orderId)
        {
            Order o = _context.Orders.Include(order=>order.AllProducts).ToList().Find(order => order.Id == orderId);
            if (o != null)
            {
                Product product = _context.Products.ToList().Find(prod => prod.Id == productId);
                if(product!=null)
                {
                    o.AllProducts.Remove(product);
                    o.SumBuying -= product.Price;
                    _context.SaveChanges();
                    return true;
                }
                else
                {
                    Console.WriteLine("there isnt such a product in this shop!");
                }
            }
            else
            {
                Console.WriteLine("there is'nt such an order");
            }  
            return false;  
        }
    }
}
