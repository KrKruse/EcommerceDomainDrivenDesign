using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Noerlund.Domain.Models;

namespace Noerlund.Domain.Repositories
{
    public interface IProductRepo
    {
        Task CreateProductAsync(Product p);
        Task DeleteProductAsync(Guid id);
        Task UpdateProductAsync(Product p);
        Product GetProductByGuidId(Guid id);
        List<Product> GetAllProductsByCategory(Guid categoryId);
    }
}
