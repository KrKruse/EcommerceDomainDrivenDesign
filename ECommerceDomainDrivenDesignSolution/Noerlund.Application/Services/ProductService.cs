using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Noerlund.Application.Models;
using Noerlund.Domain.Models;

namespace Noerlund.Application.Services
{
    public class ProductService : IProductService
    {
        public Task CreateProductAsync(ProductDto p)
        {
            throw new NotImplementedException();
        }

        public Task DeleteProductAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateProductAsync(ProductDto p)
        {
            throw new NotImplementedException();
        }

        public Product GetProductByGuidId(Guid Id)
        {
            throw new NotImplementedException();
        }

        public List<Product> getAllProductsByCategory(string Category)
        {
            throw new NotImplementedException();
        }
    }
}
