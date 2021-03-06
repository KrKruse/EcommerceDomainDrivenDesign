using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Noerlund.Application.Models;
using Noerlund.Application.Services;

namespace Noerlund.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]/")]
    [EnableCors("AllowBlazorOrigin")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _service;

        public CategoryController(ICategoryService service)
        {
            _service = service;
        }
        [HttpPost]
        public async Task<ActionResult> CreateCategory(CreateCategoryDto cat)
        {
            await _service.CreateCategoryAsync(cat);
            return Ok("Product Created");
        }

        [HttpGet("{categoryName}")]
        public ActionResult<CategoryDtoRequest> GetCategoryByGuid([FromRoute] string categoryName)
        {
            return Ok(_service.GetCategoryByGuidCategoryName(categoryName));
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<IReadOnlyList<CategoryDtoRequest>>> GetAllCategory()
        {
            return Ok(_service.getAllCategories());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory([FromRoute] Guid id)
        {
            await _service.DeleteCategoryAsync(id);
            return Ok($"Category is deleted");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCategory([FromBody] CategoryDtoRequest dto)
        {
            await _service.UpdateCategoryAsync(dto);
            return Ok("Category Updated");
        }
    }
}
