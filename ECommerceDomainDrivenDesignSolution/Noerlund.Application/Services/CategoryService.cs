using Noerlund.Application.Models;
using Noerlund.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Noerlund.Domain.Repositories;

namespace Noerlund.Application.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepo _repo;

        public CategoryService(ICategoryRepo repo)
        {
            _repo = repo;
        }
        public async Task CreateCategoryAsync(CreateCategoryDto cat)
        {
            Guid id = Guid.NewGuid();
            var category = new Category(id, cat.CategoryName );
            await _repo.CreateCategoryAsync(category);
        }

        public async Task DeleteCategoryAsync(Guid id)
        {
            // tjek om produkt er der, måske slet 
            var Cat = _repo.GetCategoryByGuidId(id);

            await _repo.DeleteCategoryAsync(id);
        }

        public List<Category> getAllCategories()
        {
            var dtos = _repo.GetAllCategoriesList();

            return dtos;
        }

        public Category GetCategoryByGuidId(Guid id)
        {
            var category = _repo.GetCategoryByGuidId(id);

            return category;
        }

        public async Task UpdateCategoryAsync(CategoryDtoRequest cat)
        {
            var toBeUpdated = new Category(cat.CategoryId, cat.CategoryName);

            await _repo.UpdateCategoryAsync(toBeUpdated);
        }
    }
}
