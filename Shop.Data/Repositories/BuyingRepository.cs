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
            Order o = _context.Orders.FirstOrDefault(ord => ord.Id == orderId);
            return o;
        }
        public bool AddProductBuy(Product product, int orderId)//add a product to the order
        {
            Order o = _context.Orders.ToList().Find(item => item.Id == orderId);
            if (o == null)
            {
                Console.WriteLine("there is'nt such order");
               
            }
            else
            {
               // Product p = _context.Products.ToList().Find(prod => prod.Id == productId);
                if (product != null)
                {
                    if (product.Amount > 0)
                    {
                        o.AllProducts.Add(product);
                        product.Amount--;
                        o.SumBuying += product.Price;
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
            _context.SaveChanges();
            return false;
        }
        public bool AddAmountBuy(Product product, int orderId)//add amount to an exists product
        {
            Order o = _context.Orders.ToList().Find(item => item.Id == orderId);
            if (o != null)
            {
                //Product p = o.AllProducts.Find(p => p.Id == productId);
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

        public bool DeleteProductBuy(Product product, int orderId)
        {
            Order o = _context.Orders.ToList().Find(order => order.Id == orderId);
            if (o != null)
            {
                o.AllProducts.Remove(_context.Products.ToList().Find(item => item.Id == product.Id));
                _context.SaveChanges();
                return true;
            }
            else
            {
                Console.WriteLine("there is'nt such an order");
                return false;            
            } 
           
        }
       
    }
}
