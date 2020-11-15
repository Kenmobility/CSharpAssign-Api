using CodingTestProj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingTestProj.Dtos
{
    public class CustomersForReturnDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Gender { get; set; }
        public List<AddressForReturnDto> Addresses { get; set; }
        public List<OrderForReturnDto> Orders { get; set; }
    }
}
