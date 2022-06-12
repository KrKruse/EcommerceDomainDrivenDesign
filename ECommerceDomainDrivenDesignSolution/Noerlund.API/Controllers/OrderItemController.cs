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
    public class OrderItemController : ControllerBase
    {
        private readonly IOrderItemService _service;

        public OrderItemController(IOrderItemService service)
        {
            _service = service;
        }
        [HttpPost]
        public async Task<ActionResult> CreateOrderItem(CreateOrderItemDto orderItemDto)
        {
            await _service.CreateOrderItemAsync(orderItemDto);
            return Ok("OrderItem Created");
        }

        [HttpGet("{id}")]
        public ActionResult<OrderItemDtoRequest> GetOrderItemByGuid([FromRoute] Guid id)
        {
            return Ok(_service.GetAllOrderItemsByOrderId(id));
        }

        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<OrderItemDtoRequest>>> GetAllOrderItems(Guid id)
        {
            return Ok(_service.GetAllOrderItemsByOrderId(id));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrderItem([FromRoute] Guid id)
        {
            await _service.DeleteOrderItemAsync(id);
            return Ok($"OrderItem is deleted");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateOrderItem([FromBody] OrderItemDtoRequest dto)
        {
            await _service.UpdateOrderItemAsync(dto);
            return Ok("OrderItem Updated");
        }
    }
}
