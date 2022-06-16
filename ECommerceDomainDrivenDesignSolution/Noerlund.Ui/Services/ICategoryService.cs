using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Noerlund.Ui.Models;

namespace Noerlund.Ui.Services
{
    public interface ICategoryService
    {
        Task<CategoryModel> CreateCategoryAsync(CategoryModel cat);
        Task<CategoryModel> DeleteCategoryAsync(Guid id);
        Task<CategoryModel> UpdateCategoryAsync(CategoryModel cat);
        Task <CategoryModel> GetCategoryByCategoryName(string categoryName);
        Task<List<CategoryModel>> GetAllCategories();
    }
}
