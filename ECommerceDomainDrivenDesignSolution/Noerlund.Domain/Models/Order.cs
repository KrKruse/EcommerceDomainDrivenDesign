using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noerlund.Domain.Models
{
    public class Order
    {
        public Guid OrderId { get; private set; }
        public int TotalPris { get; private set; }
        public Guid  CustomerId { get; private set; }

        public Order(Guid orderId, int totalPris, Guid customerId)
        {
            OrderId = orderId;
            TotalPris = totalPris;
            CustomerId = customerId;
        }
    }
}
