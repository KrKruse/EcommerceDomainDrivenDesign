using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Noerlund.Ui.Models
{
    public class CustomerModel
    {
        public Guid CustomerId { get; set; }
        public String CustomerName { get; set; }
        public String CustomerEmail { get; set; }
        public int PhoneNumber { get; set; }
    }
}
