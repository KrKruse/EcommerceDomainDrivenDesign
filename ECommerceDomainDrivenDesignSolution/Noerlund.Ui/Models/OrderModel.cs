using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Noerlund.Ui.Models
{
    public class OrderModel
    {
        public Guid OrderId { get; set; }
        public int TotalPrice { get; set; }
        public Guid CustomerId { get; set; }
    }
}
