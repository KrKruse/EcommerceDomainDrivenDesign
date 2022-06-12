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
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _service;

        public OrderController(IOrderService service)
        {
            _service = service;
        }
        [HttpPost]
        public async Task<ActionResult> CreateOrder(CreateOrderDto order)
        {
            await _service.CreateOrderAsync(order);
            return Ok("Order Created");
        }

        [HttpGet("{id}")]
        public ActionResult<OrderDtoRequest> GetOrderByGuid([FromRoute] Guid id)
        {
            return Ok(_service.GetOrderByGuidId(id));
        }

        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<OrderDtoRequest>>> GetAllOrders()
        {
            return Ok(_service.GetAllOrders());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrder([FromRoute] Guid id)
        {
            await _service.DeleteOrderAsync(id);
            return Ok($"Order is deleted");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateOrder([FromBody] OrderDtoRequest dto)
        {
            await _service.UpdateOrderAsync(dto);
            return Ok("Category Updated");
        }
    }
}
