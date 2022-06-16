using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Noerlund.Ui.Models;

namespace Noerlund.Ui.Services
{
    public interface IProductService
    {
        Task CreateProductAsync(ProductModel p);
        Task DeleteProductAsync(Guid id);
        Task UpdateProductAsync(ProductModel p);
        Task <ProductModel> GetProductByGuidId(Guid id);
        Task <List<ProductModel>> GetAllProductsByCategory(Guid categoryId);
    }
}
