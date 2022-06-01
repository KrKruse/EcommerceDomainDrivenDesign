using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noerlund.Domain.Models
{
    public class Product
    {
        public Guid ProductId { get; private set; }
        public string ProductName { get; private set; }
        public string Description { get; private set; }
        public byte[] Image { get; private set; }
        public String CategoryName { get; private set; }

        public Product(Guid id, string productName, string description, byte[] image, string categoryName)
        {
            ProductId = id;
            ProductName = productName;
            Description = description;
            Image = image;
            CategoryName = categoryName;
        }
    }
}
