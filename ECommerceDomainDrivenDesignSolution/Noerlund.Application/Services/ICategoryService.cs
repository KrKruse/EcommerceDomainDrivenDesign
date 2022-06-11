using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Noerlund.Application.Models;
using Noerlund.Domain.Models;

namespace Noerlund.Application.Services
{
    public interface ICategoryService
    {
        Task CreateCategoryAsync(CreateCategoryDto cat);
        Task DeleteCategoryAsync(Guid id);
        Task UpdateCategoryAsync(CategoryDtoRequest cat);
        Category GetCategoryByGuidId(Guid id);
        List<Category> getAllCategories();
    }
}
