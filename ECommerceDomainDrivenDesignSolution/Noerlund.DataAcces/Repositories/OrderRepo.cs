using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Microsoft.EntityFrameworkCore;
using Noerlund.DataAcces.Contexts;
using Noerlund.DataAcces.Mappers;
using Noerlund.DataAcces.Models;
using Noerlund.Domain.Models;
using Noerlund.Domain.Repositories;

namespace Noerlund.DataAcces.Repositories
{
    public class OrderRepo : IOrderRepo
    {
        private readonly NoerlundContext _context;

        public OrderRepo(NoerlundContext context)
        {
            _context = context;
        }
        public async Task CreateOrderAsync(Order ord)
        {
            var dto = Mapper.Map(ord);
            _context.Add(dto);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteOrderAsync(Guid id)
        {
            var toRemove = Find(id);

            _context.OrderDtos.Remove(toRemove);

            await _context.SaveChangesAsync();
        }

        public async Task UpdateOrderAsync(Order ord)
        {
            OrderDto dto = _context.OrderDtos.Find(ord.OrderId);

            dto.CustomerId = ord.CustomerId;

            await _context.SaveChangesAsync();
        }

        public Order GetOrderByGuidId(Guid id)
        {
            var ord = _context.OrderDtos.AsNoTracking().FirstOrDefault(f => f.CustomerId.Equals(id));
            if (ord == null)
                return null;
            return Mapper.Map(ord);
        }

        public List<Order> GetAllOrders()
        {
            var dtos = _context.OrderDtos.ToList().AsQueryable();
            return Mapper.Map(dtos);
        }
        private OrderDto Find(Guid id)
        {
            return _context.OrderDtos.Find(id);
        }
    }
}
