using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Noerlund.Domain.Models;

namespace Noerlund.Domain.Repositories
{
    public interface IOrderRepo
    {
        Task CreateOrderAsync(Order ord);
        Task DeleteOrderAsync(Guid id);
        Task UpdateOrderAsync(Order ord);
        Order GetOrderByGuidId(Guid id);
        List<Order> GetAllOrders();
    }
}
