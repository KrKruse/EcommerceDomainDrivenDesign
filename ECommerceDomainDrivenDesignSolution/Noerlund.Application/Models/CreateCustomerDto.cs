using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noerlund.Application.Models
{
    public class CreateCustomerDto
    {
        public String CustomerName { get; set; }
        public String CustomerEmail { get; set; }
        public int PhoneNumber { get; set; }
    }
}
