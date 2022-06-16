using Noerlund.Ui.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Noerlund.Ui.Extensions;

namespace Noerlund.Ui.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _client;
        public ProductService(HttpClient client)
        {
            _client = client;
        }
        public Task CreateProductAsync(ProductModel p)
        {
            throw new NotImplementedException();
        }

        public Task DeleteProductAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ProductModel>> GetAllProductsByCategory(Guid categoryId)
        {
            var response = await _client.GetAsync($"/Getall/{categoryId}");
            return await response.ReadContentAs<List<ProductModel>>();
        }

        public Task<ProductModel> GetProductByGuidId(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateProductAsync(ProductModel p)
        {
            throw new NotImplementedException();
        }
    }
}
