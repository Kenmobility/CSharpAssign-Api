using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingTestProj.Dtos
{
    public class OrderForReturnDto
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public double Amount { get; set; }
    }
}
