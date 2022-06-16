using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Noerlund.Domain.Models;

namespace Noerlund.Domain.Repositories
{
    public interface ICategoryRepo
    {
        Task CreateCategoryAsync(Category cat);
        Task DeleteCategoryAsync(Guid id);
        Task UpdateCategoryAsync(Category cat);
        Category GetCategoryByGuidId(String categoryName);
        List<Category> GetAllCategoriesList();
    }
}
