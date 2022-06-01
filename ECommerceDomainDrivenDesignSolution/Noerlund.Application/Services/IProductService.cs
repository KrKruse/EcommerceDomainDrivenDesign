using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Noerlund.Application.Models;
using Noerlund.Domain.Models;

namespace Noerlund.Application.Services
{
    public interface IProductService
    {
        Task CreateProductAsync(ProductDto p);
        Task DeleteProductAsync(Guid id);
        Task UpdateProductAsync(ProductDto p);
        Product GetProductByGuidId(Guid id);
        List<Product> getAllProductsByCategory(string category);
    }
}
