using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingTestProj.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string  PostCode { get; set; }
        public int HouseNumber { get; set; }
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }

    }
}
