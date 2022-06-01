using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noerlund.Domain.Models
{
    public class Category
    {
        public string CategoryName { get; private set; }

        public Category(string name)
        {
            CategoryName = name;
        }
    }
}
