using Shop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Repositories
{
    public interface IProductRepository
    {
        List<Product> GetList();
        Product GetProductById(int productId);
        bool AddProduct(Product product);
        void UpdateAmount(int productId, int numNews);
        void UpdatePrice(int productId, double newPrice);
        void DeleteProduct(int productId);
    }
}
