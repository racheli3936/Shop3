using Microsoft.AspNetCore.Mvc;
using Shop.Core.Entities;
using Shop.Core.Services;
using Shop.Service;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Shop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        // GET: api/<ProductsController>
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _productService.GetListS();
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public Product Get(int id)
        {
            return _productService.GetProductByIdS(id);
        }

        // POST api/<ProductsController>
        //// POST api/<ProductsController>
        [HttpPost()]
        public ActionResult<bool> Post([FromBody] Product product)
        {
            bool flag = _productService.AddProductS(product);
            if (!flag)
            {
                return NotFound(flag);
            }
            return Ok(flag);

        }

        //// PUT api/<ProductsController>/5
        [HttpPut("updateAmount/{id}/{numNews}")]
        public void Put([FromBody] int productId, int numNews)
        {
            _productService.UpdateAmountS(productId, numNews);
        }
        //// PUT api/<ProductsController>/5
        [HttpPut("updatePrice/{id}/{newPrice}")]
        public void Put(int productId, double newPrice)
        {
            _productService.UpdatePriceS(productId, newPrice);
        }

        //// DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public void Delete(int productId)
        {
            _productService.DeleteProductS(productId);
        }
    }
}
