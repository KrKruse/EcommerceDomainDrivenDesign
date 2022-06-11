using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noerlund.Application.Models
{
    public class CategoryDtoRequest
    {
        public Guid CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
