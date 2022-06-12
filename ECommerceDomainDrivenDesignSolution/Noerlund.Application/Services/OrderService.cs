using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Noerlund.Application.Models;
using Noerlund.Domain.Models;
using Noerlund.Domain.Repositories;

namespace Noerlund.Application.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepo _repo;

        public OrderService(IOrderRepo repo)
        {
            _repo = repo;
        }
        public async Task CreateOrderAsync(CreateOrderDto order)
        {
            // tjek om produkt er der, måske slet 
            Guid id = Guid.NewGuid();
            var ord = new Order(id, order.CustomerId);
            await _repo.CreateOrderAsync(ord);
        }

        public async Task DeleteOrderAsync(Guid id)
        {
            var ord = _repo.GetOrderByGuidId(id);

            await _repo.DeleteOrderAsync(id);
        }

        public async Task UpdateOrderAsync(OrderDtoRequest order)
        {
            var toBeUpdated = new Order(order.OrderId, order.CustomerId);

            await _repo.UpdateOrderAsync(toBeUpdated);
        }

        public Order GetOrderByGuidId(Guid id)
        {
            var order = _repo.GetOrderByGuidId(id);

            return order;
        }

        public List<Order> GetAllOrders()
        {
            var dtos = _repo.GetAllOrders();

            return dtos;
        }
    }
}
