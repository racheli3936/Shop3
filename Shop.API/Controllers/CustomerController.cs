using Microsoft.AspNetCore.Mvc;
using Shop.Core.Entities;
using Shop.Core.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Shop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet("manager/{password}")]
        public List<Customer> Get(int password)
        {

            return _customerService.GetAllCustomersS(password);
        }
        [HttpGet("customer/{identity}")]
        public Customer Get(string identity)
        {
            return _customerService.GetCustomerByIdS(identity);
        }
        //// POST api/<ClubCardController>
        [HttpPost()]
        public void Post([FromBody]Customer customer,int employeeId)
        {
            _customerService.AddNewCustomerS(customer, employeeId);
        }

        //// PUT api/<ClubCardController>/5
        [HttpPut()]
        public void Put(string custIdentity, double sumPay)
        {
            _customerService.UpdatePointsS(custIdentity, sumPay);
        }
    }
}
