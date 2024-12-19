using Microsoft.AspNetCore.Mvc;
using Shop.Core.Entities;
using Shop.Core.Services;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Shop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrdersService _ordersService;
        public OrdersController(IOrdersService ordersService)
        {
            this._ordersService = ordersService;
        }

        // GET: api/<Orders>

        [HttpGet]
        public List<Order> Get()//return all orders
        {
            return _ordersService.GetOrdersS();
        }

        // GET api/<OrdersController>/5
        [HttpGet("{id}")]//return special order
        public Order Get(int orderId)
        {
            return _ordersService.GetOrderByIdS(orderId);
        }

        // POST api/<OrdersController>
        [HttpPost]
        public int Post([FromBody] int custId)//make a new empty order and return its id
        {
            return _ordersService.AddOrderS(custId);
        }

        //// PUT api/<Orders>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<Orders>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
