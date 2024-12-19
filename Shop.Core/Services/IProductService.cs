using Shop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Services
{
    public interface IProductService
    {
        List<Product> GetListS();
        Product GetProductByIdS(int productId);
        bool AddProductS(Product product);
        void UpdateAmountS(int productId, int numNews);
        void UpdatePriceS(int productId, double newPrice);
        void DeleteProductS(int productId);
    }
}
