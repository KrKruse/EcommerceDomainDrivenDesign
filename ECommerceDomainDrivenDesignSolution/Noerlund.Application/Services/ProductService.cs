using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Noerlund.Application.Models;
using Noerlund.Domain.Models;
using Noerlund.Domain.Repositories;

namespace Noerlund.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepo _repo;

        public ProductService(IProductRepo repo)
        {
            _repo = repo;
        }

        public async Task DeleteProductAsync(Guid id)
        {
            // tjek om produkt er der, måske slet 
            var prod = _repo.GetProductByGuidId(id);
            
            await _repo.DeleteProductAsync(id);
        }

        public async Task UpdateProductAsync(ProductDtoRequest p)
        {
            var toBeUpdated = new Product(p.ProductId, p.ProductPrice, p.ProductName, p.Description, p.CategoryId);

            await _repo.UpdateProductAsync(toBeUpdated);
        }

        public Product GetProductByGuidId(Guid Id)
        {
            var prod = _repo.GetProductByGuidId(Id);

            return prod;
        }

        public List<Product> getAllProductsByCategory(Guid categoryId)
        {
            var dtos = _repo.GetAllProductsByCategory(categoryId);

            return dtos;
        }

        public async Task CreateProductAsync(CreateProductDto p)
        {
            var product = new Product(p.ProductId, p.Price, p.ProductName, p.Description, p.CategoryId);
            await _repo.CreateProductAsync(product);
        }
    }
}
