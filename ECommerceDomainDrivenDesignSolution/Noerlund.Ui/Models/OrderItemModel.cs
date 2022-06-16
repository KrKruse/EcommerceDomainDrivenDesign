using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Noerlund.Ui.Models
{
    public class OrderItemModel
    {
        public Guid OrderItemId { get; set; }
        public int Quantity { get; set; }
        public Guid OrderId { get; set; }
        public Guid ProductId { get; set; }
    }
}
