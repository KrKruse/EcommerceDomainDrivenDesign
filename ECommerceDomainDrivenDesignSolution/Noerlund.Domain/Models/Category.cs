using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noerlund.Domain.Models
{
    public class Category
    {
        public Guid CategoryId { get; private set; }
        public string CategoryName { get; private set; }

        public Category(Guid categoryId, string name)
        {
            CategoryId = categoryId;
            CategoryName = name;
        }
    }
}
