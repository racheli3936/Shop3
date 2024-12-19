using Shop.Core.Entities;
using Shop.Core.Repositories;
using Shop.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Service
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public List<Product> GetListS()
        {
            return _productRepository.GetList();
        }
        public Product GetProductByIdS(int productId)
        {
            return _productRepository.GetProductById(productId);
        }
       public bool AddProductS(Product product)
        {
            return _productRepository.AddProduct(product);
        }
        public void UpdateAmountS(int productId, int numNews)
        {
            _productRepository.UpdateAmount(productId, numNews);
        }
        public void UpdatePriceS(int productId, double newPrice)
        {
            _productRepository.UpdatePrice(productId, newPrice);
        }
        public void DeleteProductS(int productId)
        {
            _productRepository.DeleteProduct(productId);
        }
    }
}
