using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noerlund.Domain.Models
{
    public class Customer
    { public Guid CustomerId { get; private set; }
        public String CustomerName { get; private set; }
        public String CustomerEmail { get; private set; }
        public int PhoneNumber { get; private set; }

        public Customer(Guid id, string name, string email, int number)
        {
            CustomerId = id;
            CustomerName = name;
            CustomerEmail = email;
            PhoneNumber = number;
        }
    }
}
