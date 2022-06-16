using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Noerlund.Ui.Models;

namespace Noerlund.Ui.Services
{
    public interface IOrderItemService
    {
        Task CreateOrderItemAsync(OrderItemModel orderItem);
        Task DeleteOrderItemAsync(Guid id);
        Task UpdateOrderItemAsync(OrderItemModel orderItem);
        Task <OrderItemModel> GetOrderItemByGuidId(Guid id);
        Task <List<OrderModel>> GetAllOrderItemsByOrderId(Guid orderId);
    }
}
