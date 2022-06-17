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
        public int Pris { get; private set; }
        public string ProductName { get; private set; }
        public string Description { get; private set; }
        public Guid CategoryId { get; private set; }

        public Product(Guid id, int pris, string productName, string description, Guid categoryId)
        {
            ProductId = id;
            Pris = pris;
            ProductName = productName;
            Description = description;
            CategoryId = categoryId;
        }
    }
}
