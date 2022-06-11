using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Noerlund.Application.Models;
using Noerlund.Application.Services;

namespace Noerlund.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]/")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _service;

        public ProductController(IProductService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<ActionResult> CreateProduct(CreateProductDto p)
        {
            await _service.CreateProductAsync(p);
            return Ok("Product Created");
        }

        [HttpGet("{id}")]
        public ActionResult<ProductDtoRequest> GetProductByGuid([FromRoute] Guid id)
        {
            return Ok(_service.GetProductByGuidId(id));
        }

        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<ProductDtoRequest>>> GetAllProductsByCategoryGuid(Guid id)
        {
            return Ok(_service.getAllProductsByCategory(id));
        }
        
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct([FromRoute] Guid id)
        {
            await _service.DeleteProductAsync(id);
            return Ok($"Product is deleted");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateExpiredMediaContentRule([FromBody] ProductDtoRequest dto)
        {
            await _service.UpdateProductAsync(dto);
            return Ok("Rule Updated");
        }

    }
}
