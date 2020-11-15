using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingTestProj.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public double Amount { get; set; }
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
    }
}
