using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Noerlund.Application.Models
{
    public class CreateOrderDto
    {
        public Guid OrderId { get; set; }
        public Guid CustomerId { get; set; }
        public int TotalPrice { get; set; }


    }
}
