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
        public BuyingController(IBuyingService buyingService)
        {
            _buyingService = buyingService;
        }
        // GET api/<BuyingController>/5
        [HttpGet("{orderId}")]
        public ActionResult<Order> Get(int orderId)//מחזיר את החשבונית בSTRING
        {
            return _buyingService.GetBuyingS(orderId);
        }

        // POST api/<BuyingController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Product product, int orderId)//add a product to the order
        {
            bool flag = _buyingService.AddProductBuyS(product, orderId);
            if (!flag)
            {
                return NotFound(false);
            }
            return Ok(true);
        }

        //// PUT api/<BuyingController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put([FromBody] Product product, int orderId)//add amount to an exists product
        {
            bool flag = _buyingService.AddAmountBuyS(product, orderId);
            if (!flag) { return NotFound(false); }
            return Ok(true);
        }

        //// DELETE api/<BuyingController>/5
        [HttpDelete("{productId}")]//delete a product from the order
        public ActionResult<bool> Delete([FromBody]Product product, int orderId)
        {
            bool flag = _buyingService.DeleteProductBuyS(product, orderId);
            if (!flag) { return NotFound(false); }
            return Ok(true);
        }
    }
}
