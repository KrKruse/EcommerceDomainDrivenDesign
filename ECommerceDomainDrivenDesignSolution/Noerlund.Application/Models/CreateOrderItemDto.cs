using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noerlund.Application.Models
{
    public class CreateOrderItemDto
    {
        public Guid OrderItemId { get; set; }
        public int Quantity { get; set; }

        public Guid OrderId { get; set; }
        public Guid ProductId { get; set; }
    }
}
