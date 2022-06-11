using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noerlund.DataAcces.Models
{
    public class CategoryDto
    {
        [Key]
        public Guid CategoryId { get; set; }
        public string CategoryName { get; set; }

        public ICollection<ProductDto> ProductsDtos { get; set; }
    }
}
