using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Shop.Core.DTOs;
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
        private readonly IMapper _mapper;
        public ProductsController(IProductService productService,IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }
        // GET: api/<ProductsController>
        [HttpGet]
        public IEnumerable<ProductDto> Get()
        {
            List<Product> products = _productService.GetListS();
            List<ProductDto> listDto = _mapper.Map<List<ProductDto>>(products);
            return listDto;
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public ProductDto Get(int id)
        {
            Product product=_productService.GetProductByIdS(id);
            ProductDto prodDto=_mapper.Map<ProductDto>(product);
            return prodDto;
        }

        // POST api/<ProductsController>
        //// POST api/<ProductsController>
        [HttpPost]
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
        [HttpPut("updateAmount/{productId}")]
        public void Put([FromBody] int numNews, int productId)
        {
            _productService.UpdateAmountS(productId, numNews);
        }
        //// PUT api/<ProductsController>/5
        [HttpPut("updatePrice/{productId}")]
        public void Put([FromBody] double newPrice,int productId)
        {
            _productService.UpdatePriceS(productId, newPrice);
        }

        //// DELETE api/<ProductsController>/5
        [HttpDelete("{productId}")]
        public void Delete(int productId)
        {
            _productService.DeleteProductS(productId);
        }
    }
}
