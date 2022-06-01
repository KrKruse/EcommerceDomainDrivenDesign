using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Noerlund.Domain.Models
{
    public class OrderItem
    {
        public Guid OrderItemId { get; private set; }
        public Guid OrderId { get; private set; }
        public Guid ProductId { get; private set; }
        public int Quantity { get; private set; }

        public OrderItem(Guid orderItemId, Guid orderId, Guid productId, int quantity)
        {
            OrderItemId = orderItemId;
            OrderId = orderId;
            ProductId = productId;
            Quantity = quantity;
        }
    }
}
