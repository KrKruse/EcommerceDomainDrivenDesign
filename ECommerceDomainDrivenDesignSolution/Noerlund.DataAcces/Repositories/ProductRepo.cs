
using Noerlund.Domain.Repositories;
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

namespace Noerlund.DataAcces.Repositories
{
    public class ProductRepo : IProductRepo
    {
        private readonly NoerlundContext _context;

        public ProductRepo(NoerlundContext context)
        {
            _context = context;
        }
        public async Task CreateProductAsync(Product p)
        {
            var dto = Mapper.Map(p);
            _context.Add(dto);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteProductAsync(Guid id)
        {
            var toRemove = Find(id);

            _context.ProductDtos.Remove(toRemove);

            await _context.SaveChangesAsync();
        }

        public async Task UpdateProductAsync(Product p)
        {
            ProductDto dto = _context.ProductDtos.Find(p.ProductId);

            dto.ProductId = p.ProductId;
            dto.Pris = p.Pris;
            dto.ProductName = p.ProductName;
            dto.Description = p.Description;
            dto.CategoryId = p.CategoryId;

            await _context.SaveChangesAsync();
        }

        public Product GetProductByGuidId(Guid id)
        {
            var pro = _context.ProductDtos.AsNoTracking().ToList().FirstOrDefault(f => f.ProductId.Equals(id));
            if (pro == null)
                return null;

            return Mapper.Map(pro);
        }

        private ProductDto Find(Guid id)
        {
            return _context.ProductDtos.Find(id);
        }

        public List<Product> GetAllProductsByCategory(Guid categoryId)
        {
            var dtos = _context.ProductDtos.AsNoTracking().Where(o => o.CategoryId.Equals(categoryId)).ToList().AsQueryable();
            return Mapper.Map(dtos);
        }
    }
}
