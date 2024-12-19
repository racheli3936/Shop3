using Shop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Repositories
{
    public interface IBuyingRepository
    {
        Order GetBuying(int orderId);
        bool AddProductBuy(Product product, int orderId);
        bool AddAmountBuy(Product product, int orderId);
        bool DeleteProductBuy(Product product, int orderId);
    }
}
