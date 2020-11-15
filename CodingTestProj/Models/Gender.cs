using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingTestProj.Models
{
    public enum GenderEnum
    {
        Male,
        Female
    }

    public class Gender
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
