using AutoMapper;
using CodingTestProj.Dtos;
using CodingTestProj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingTestProj.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
           
            CreateMap<Customer, CustomersForReturnDto>();
            CreateMap<Address, AddressForReturnDto>();
            CreateMap<Order,OrderForReturnDto>();

            CreateMap<CustomerForUpdateDto, Customer>();
            CreateMap<CustomerForCreationDto, Customer>();
        }
    }
}
