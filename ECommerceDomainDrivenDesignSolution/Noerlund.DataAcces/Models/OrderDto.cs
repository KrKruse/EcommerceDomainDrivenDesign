using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noerlund.DataAcces.Models
{
    public class OrderDto
    {
        [Key]
        public Guid OrderId { get; set; }
        public  int TotalPris { get; set; }

        public Guid CustomerId { get; set; }
        [ForeignKey(nameof(CustomerId))]
        public CustomerDto CustomerDto { get; set; }


        public ICollection<OrderItemDto> OrderItemDtos { get; set; }
    }
}
