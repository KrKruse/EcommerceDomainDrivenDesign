using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Noerlund.DataAcces.Models;
using Noerlund.Domain.Models;

namespace Noerlund.DataAcces.Mappers
{
    public static class Mapper
    {
        public static ProductDto Map(Product product)
        {
            return new ProductDto
            {
                ProductId = product.ProductId,
                ProductName = product.ProductName,
                Description = product.Description,
                Image = product.Image,
                CategoryId = product.CategoryId
            };
        }
        public static Product Map(ProductDto dto)
        {
            var expiredMediaContentRule = new Product(dto.ProductId, dto.ProductName, dto.Description, dto.Image, dto.CategoryId);
            return expiredMediaContentRule;
        }
        public static List<Product> Map(IQueryable<ProductDto> dtos)
        {
            var types = new List<Product>();
            foreach (var d in dtos)
            {
                var type = new Product(d.ProductId, d.ProductName, d.Description, d.Image, d.CategoryId);

                types.Add(type);
            }

            return types;
        }
    }
}
