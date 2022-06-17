using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noerlund.DataAcces.Models
{
    public class ProductDto
    {
        [Key]
        public Guid ProductId { get; set; }
        public int Pris { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }

        public Guid CategoryId { get; set; }
        [ForeignKey(nameof(CategoryId))]
        public CategoryDto CategoryDto { get; set; }
    }
}
