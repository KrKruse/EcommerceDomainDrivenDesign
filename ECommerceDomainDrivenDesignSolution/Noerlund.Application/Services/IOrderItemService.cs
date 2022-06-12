using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Noerlund.Application.Models;
using Noerlund.Domain.Models;

namespace Noerlund.Application.Services
{
    public interface IOrderItemService
    {
        Task CreateOrderItemAsync(CreateOrderItemDto orderItem);
        Task DeleteOrderItemAsync(Guid id);
        Task UpdateOrderItemAsync(OrderItemDtoRequest orderItem);
        OrderItem GetOrderItemByGuidId(Guid id);
        List<OrderItem> GetAllOrderItemsByOrderId(Guid orderId);
    }
}
