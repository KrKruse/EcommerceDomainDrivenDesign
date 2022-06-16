using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Noerlund.Ui.Extensions;
using Noerlund.Ui.Models;

namespace Noerlund.Ui.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly HttpClient _client;
        public CategoryService(HttpClient client)
        {
            _client = client;
        }

        public async Task<CategoryModel> CreateCategoryAsync(CategoryModel cat)
        {
            var response = await _client.PostAsJson($"/api/v1/Category", cat);
            if (response.IsSuccessStatusCode)
                return await response.ReadContentAs<CategoryModel>();
            else
            {
                throw new Exception("Something went wrong when calling api.");
            }
        }

        public async Task<CategoryModel> DeleteCategoryAsync(Guid id)
        {
            var response = await _client.DeleteAsync($"/api/v1/Category/{id}");
            if (response.IsSuccessStatusCode)
                return await response.ReadContentAs<CategoryModel>();
            else
            {
                throw new Exception("Something went wrong when calling api.");
            }
        }

        public async Task<List<CategoryModel>> GetAllCategories()
        {
            var response = await _client.GetAsync("/api/v1/Category/GetAll");
            return await response.ReadContentAs<List<CategoryModel>>();
        }

        public async Task<CategoryModel> GetCategoryByCategoryName(string categoryName)
        {
            var response = await _client.GetAsync($"/api/v1/Category/{categoryName}");
            return await response.ReadContentAs<CategoryModel>();
        }

        public async Task<CategoryModel> UpdateCategoryAsync(CategoryModel cat)
        {
            var response = await _client.PutAsJson($"/api/v1/Category/{cat.CategoryId}", cat);
            if (response.IsSuccessStatusCode)
                return await response.ReadContentAs<CategoryModel>();
            else
            {
                throw new Exception("Something went wrong when calling api.");
            }
        }
    }
}
