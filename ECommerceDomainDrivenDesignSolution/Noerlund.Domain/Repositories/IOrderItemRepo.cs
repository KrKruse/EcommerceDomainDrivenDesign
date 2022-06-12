using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Noerlund.Domain.Models;

namespace Noerlund.Domain.Repositories
{
    public interface IOrderItemRepo
    {
        Task CreateOrderItemAsync(OrderItem orderItem);
        Task DeleteOrderItemAsync(Guid id);
        Task UpdateOrderItemAsync(OrderItem orderItem);
        OrderItem GetOrderItemByGuidId(Guid id);
        List<OrderItem> GetAllOrderItemsByOrderId(Guid OrderId);
    }
}
