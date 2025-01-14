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
        bool AddProductBuy(int productId, int orderId);
        bool AddAmountBuy(int productId, int orderId);
        bool DeleteProductBuy(int productId, int orderId);
    }
}
