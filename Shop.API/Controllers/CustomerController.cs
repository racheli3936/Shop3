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
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        private readonly IMapper _mapper;
        public CustomerController(ICustomerService customerService,IMapper mapper)
        {
            _customerService = customerService;
            _mapper=mapper;
        }

        [HttpGet("manager/{password}")]
        public List<CustomerDto> Get(int password)
        {
            List<Customer> result = _customerService.GetAllCustomersS(password);
            List<CustomerDto> listDto = _mapper.Map<List<CustomerDto>>(result);
            return listDto;
        }
        [HttpGet("customer/{identity}")]
        public CustomerDto Get(string identity)
        {
            Customer customer= _customerService.GetCustomerByIdS(identity);
            CustomerDto custDto=_mapper.Map<CustomerDto>(customer);
            return custDto;
        }
        //// POST api/<ClubCardController>
        [HttpPost()]
        public void Post([FromBody]Customer customer,int employeeId)
        {
            _customerService.AddNewCustomerS(customer, employeeId);
        }

        //// PUT api/<ClubCardController>/5
        [HttpPut()]//update Score in the clubCard
        public void Put(string custIdentity, double sumPay)
        {
            _customerService.UpdatePointsS(custIdentity, sumPay);
        }
    }
}
