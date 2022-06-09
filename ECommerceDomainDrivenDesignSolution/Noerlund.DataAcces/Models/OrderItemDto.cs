using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noerlund.DataAcces.Models
{
    public class OrderItemDto
    {
        [Key]
        public Guid OrderItemId { get; set; }
        public int Quantity { get; set; }

        public Guid OrderId { get; set; }
        [ForeignKey(nameof(OrderId))]
        public OrderDto OrderDto { get; set; }

        public ICollection<ProductDto> ProductDtos { get; set; }

    }
}
