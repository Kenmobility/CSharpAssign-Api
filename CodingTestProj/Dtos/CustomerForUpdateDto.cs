using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodingTestProj.Dtos
{
    public class CustomerForUpdateDto
    {
        public CustomerForUpdateDto()
        {
            this.CreatedDate = DateTime.Now;
        }
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Gender { get; set; }
    }
}
