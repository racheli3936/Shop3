using AutoMapper;
using Shop.Core.DTOs;
using Shop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core
{
    public class MappingProfile:Profile
    {
        public MappingProfile() 
        {
            CreateMap<Product,ProductDto>().ReverseMap();
            CreateMap<Customer,CustomerDto>().ReverseMap();
            CreateMap<Order,OrderDto>().ReverseMap();
        }

    }
}
