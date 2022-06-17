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

        public async Task<CreateProductModel> CreateProductAsync(ProductModel p)
        {
            var response = await _client.PostAsJson($"/api/v1/Product", p);
            if (response.IsSuccessStatusCode)
                return await response.ReadContentAs<CreateProductModel>();
            else
            {
                throw new Exception("Something went wrong when calling api.");
            }
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

        public async Task<ProductModel> GetProductByGuidId(Guid id)
        {
            var response = await _client.GetAsync($"/api/v1/Product/{id}");
            return await response.ReadContentAs<ProductModel>();
        }

        public async Task<ProductModel> UpdateProductAsync(ProductModel p)
        {
            var response = await _client.PutAsJson($"/api/v1/Product/{p.ProductId}", p);
            if (response.IsSuccessStatusCode)
                return await response.ReadContentAs<ProductModel>();
            else
            {
                throw new Exception("Something went wrong when calling api.");
            }
        }
    }
}
