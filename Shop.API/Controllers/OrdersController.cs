using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Shop.Core.DTOs;
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
        private readonly IMapper _mapper;
        public OrdersController(IOrdersService ordersService,IMapper mapper)
        {
            this._ordersService = ordersService;
            _mapper = mapper;   
        }

        // GET: api/<Orders>

        [HttpGet]
        public List<OrderDto> Get()//return all orders
        {
            List<Order> orders = _ordersService.GetOrdersS();
            List<OrderDto> ordDto = _mapper.Map<List<OrderDto>>(orders);

            return ordDto;
        }

        // GET api/<OrdersController>/5
        [HttpGet("{orderId}")]//return special order
        public OrderDto Get(int orderId)
        {
            Order order= _ordersService.GetOrderByIdS(orderId);
            OrderDto orderDto=_mapper.Map<OrderDto>(order);
            return orderDto;
        }

        // POST api/<OrdersController>
        [HttpPost]
        public int Post([FromBody] string Identity)//make a new empty order and return its id
        {
            return _ordersService.AddOrderS(Identity);
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
