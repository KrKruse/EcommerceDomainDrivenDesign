using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Noerlund.Application.Models;
using Noerlund.Domain.Models;

namespace Noerlund.Application.Services
{
    public interface IOrderService
    {
        Task CreateOrderAsync(CreateOrderDto order);
        Task DeleteOrderAsync(Guid id);
        Task UpdateOrderAsync(OrderDtoRequest order);
        Order GetOrderByGuidId(Guid id);
        List<Order> GetAllOrders();
    }
}
