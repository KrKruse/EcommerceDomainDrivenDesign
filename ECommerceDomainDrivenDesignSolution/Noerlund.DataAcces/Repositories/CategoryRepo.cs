using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Noerlund.DataAcces.Contexts;
using Noerlund.DataAcces.Mappers;
using Noerlund.DataAcces.Models;
using Noerlund.Domain.Models;
using Noerlund.Domain.Repositories;

namespace Noerlund.DataAcces.Repositories
{
    public class CategoryRepo : ICategoryRepo
    {
        private readonly NoerlundContext _context;

        public CategoryRepo(NoerlundContext context)
        {
            _context = context;
        }
        public async Task CreateCategoryAsync(Category cat)
        {
            var dto = Mapper.Map(cat);
            _context.Add(dto);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCategoryAsync(Guid id)
        {
            var toRemove = Find(id);

            _context.CategoryDtos.Remove(toRemove);

            await _context.SaveChangesAsync();
        }

        public Category GetCategoryByGuidId(string categoryName)
        {
            var cat = _context.CategoryDtos.AsNoTracking().ToList().FirstOrDefault(f => f.CategoryName.Equals(categoryName));
            if (cat == null)
                return null;

            return Mapper.Map(cat);
        }

        public async Task UpdateCategoryAsync(Category cat)
        {
            CategoryDto dto = _context.CategoryDtos.Find(cat.CategoryId);

            dto.CategoryId = cat.CategoryId;
            dto.CategoryName = cat.CategoryName;

            await _context.SaveChangesAsync();
        }
        private CategoryDto Find(Guid id)
        {
            return _context.CategoryDtos.Find(id);
        }

        List<Category> ICategoryRepo.GetAllCategoriesList()
        {
            var dtos = _context.CategoryDtos.ToList().AsQueryable();
            return Mapper.Map(dtos);
        }
    }
}
