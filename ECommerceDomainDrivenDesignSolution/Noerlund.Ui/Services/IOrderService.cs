using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Noerlund.Ui.Models;

namespace Noerlund.Ui.Services
{
    public interface IOrderService
    {
        Task <OrderModel> CreateOrderAsync(OrderModel order);
        Task DeleteOrderAsync(Guid id);
        Task UpdateOrderAsync(OrderModel order);
        Task<OrderModel> GetOrderByGuidId(Guid id);
        Task <List<OrderModel>> GetAllOrders();
    }
}
