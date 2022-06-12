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
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _service;

        public CustomerController(ICustomerService service)
        {
            _service = service;
        }
        [HttpPost]
        public async Task<ActionResult> CreateCustomer(CreateCustomerDto customer)
        {
            await _service.CreateCustomerAsync(customer);
            return Ok("Customer Created");
        }

        [HttpGet("{id}")]
        public ActionResult<CustomerDtoRequest> GetCustomerByGuid([FromRoute] Guid id)
        {
            return Ok(_service.GetCustomerByGuidId(id));
        }

        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<CustomerDtoRequest>>> GetAllCustomers()
        {
            return Ok(_service.GetAllCustomer());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomer([FromRoute] Guid id)
        {
            await _service.DeleteCustomerAsync(id);
            return Ok($"Customer is deleted");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCustomer([FromBody] CustomerDtoRequest dto)
        {
            await _service.UpdateCustomerAsync(dto);
            return Ok("Category Updated");
        }
    }
}
