using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noerlund.Application.Models
{
    public class CreateProductDto
    {
        public string ProductName { get; set; }
        public string Description { get; set; }
        public Guid CategoryId { get; set; }
    }
}
