using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noerlund.DataAcces.Models
{
    public class CustomerDto
    {
        [Key]
        public Guid CustomerId { get; set; }
        public String CustomerName { get; set; }
        public String CustomerEmail { get; set; }
        public int PhoneNumber { get; set; }
    }
}
