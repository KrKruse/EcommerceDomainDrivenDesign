using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Noerlund.DataAcces.Contexts;
using Noerlund.DataAcces.Mappers;
using Noerlund.DataAcces.Models;
using Noerlund.Domain.Models;
using Noerlund.Domain.Repositories;

namespace Noerlund.DataAcces.Repositories
{
    public class OrderItemRepo : IOrderItemRepo
    {
        private readonly NoerlundContext _context;

        public OrderItemRepo(NoerlundContext context)
        {
            _context = context;
        }

        public async Task CreateOrderItemAsync(OrderItem orderItem)
        {
            var dto = Mapper.Map(orderItem);
            _context.Add(dto);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteOrderItemAsync(Guid id)
        {
            var toRemove = Find(id);

            _context.OrderItemDtos.Remove(toRemove);

            await _context.SaveChangesAsync();
        }

        public async Task UpdateOrderItemAsync(OrderItem orderItem)
        {
            OrderItemDto dto = _context.OrderItemDtos.Find(orderItem.OrderItemId);

            dto.OrderItemId = orderItem.OrderItemId;
            dto.ProductId = orderItem.ProductId;
            dto.OrderId = orderItem.OrderId;
            dto.Quantity = orderItem.Quantity;

            await _context.SaveChangesAsync();
        }

        public OrderItem GetOrderItemByGuidId(Guid id)
        {
            var orderItem = _context.OrderItemDtos.AsNoTracking().FirstOrDefault(f => f.OrderItemId.Equals(id));
            if (orderItem == null)
                return null;
            return Mapper.Map(orderItem);
        }

        public List<OrderItem> GetAllOrderItemsByOrderId(Guid OrderId)
        {
            var dtos = _context.OrderItemDtos.AsNoTracking().Where(o => o.OrderId.Equals(OrderId)).ToList().AsQueryable();
            return Mapper.Map(dtos);
        }
        private OrderItemDto Find(Guid id)
        {
            return _context.OrderItemDtos.Find(id);
        }
    }
}
