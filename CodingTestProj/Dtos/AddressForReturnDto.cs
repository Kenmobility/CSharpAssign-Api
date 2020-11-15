using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingTestProj.Dtos
{
    public class AddressForReturnDto
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string PostCode { get; set; }
        public int HouseNumber { get; set; }
    }
}
