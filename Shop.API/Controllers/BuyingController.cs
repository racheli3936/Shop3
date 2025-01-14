using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Shop.Core.Entities;
using Shop.Core.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Shop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuyingController : ControllerBase
    {
        private readonly IBuyingService _buyingService;
        private readonly IMapper _mapper;
        public BuyingController(IBuyingService buyingService,IMapper mapper)
        {
            _buyingService = buyingService;
            _mapper = mapper;
        }
        // GET api/<BuyingController>/5
        [HttpGet("{orderId}")]
        public ActionResult<Order> Get(int orderId)//מחזיר את החשבונית בSTRING
        {
            return _buyingService.GetBuyingS(orderId);
        }

        // POST api/<BuyingController>
        [HttpPost]
        public ActionResult<bool> Post(int productId, int orderId)//add a product to the order
        {
            bool flag = _buyingService.AddProductBuyS(productId, orderId);
            if (!flag)
            {
                return NotFound(false);
            }
            return Ok(true);
        }

        //// PUT api/<BuyingController>/5
        [HttpPut("{orderId}")]
        public ActionResult<bool> Put(int productId, int orderId)//add amount to an exists product
        {
            bool flag = _buyingService.AddAmountBuyS(productId, orderId);
            if (!flag) { return NotFound(false); }
            return Ok(true);
        }

        //// DELETE api/<BuyingController>/5
        [HttpDelete("{productId}")]//delete a product from the order
        public ActionResult<bool> Delete(int productId , int orderId)
        {
            bool flag = _buyingService.DeleteProductBuyS(productId, orderId);
            if (!flag) { return NotFound(false); }
            return Ok(true);
        }
    }
}
