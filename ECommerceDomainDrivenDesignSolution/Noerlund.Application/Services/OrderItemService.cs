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
    public class OrderItemService : IOrderItemService
    {
        private readonly IOrderItemRepo _repo;

        public OrderItemService(IOrderItemRepo repo)
        {
            _repo = repo;
        }
        public async Task CreateOrderItemAsync(CreateOrderItemDto orderItem)
        {
            
            var orderIt = new OrderItem(orderItem.OrderItemId, orderItem.OrderId, orderItem.ProductId, orderItem.Quantity);
            await _repo.CreateOrderItemAsync(orderIt);
        }

        public async Task DeleteOrderItemAsync(Guid id)
        {
            var orderItem = _repo.GetOrderItemByGuidId(id);

            await _repo.DeleteOrderItemAsync(id);
        }

        public async Task UpdateOrderItemAsync(OrderItemDtoRequest orderItem)
        {
            var toBeUpdated = new OrderItem(orderItem.OrderItemId, orderItem.OrderId, orderItem.ProductId, orderItem.Quantity);

            await _repo.UpdateOrderItemAsync(toBeUpdated);
        }

        public OrderItem GetOrderItemByGuidId(Guid id)
        {
            var orderIt = _repo.GetOrderItemByGuidId(id);

            return orderIt;
        }

        public List<OrderItem> GetAllOrderItemsByOrderId(Guid orderId)
        {
            var dtos = _repo.GetAllOrderItemsByOrderId(orderId);

            return dtos;
        }
    }
}
