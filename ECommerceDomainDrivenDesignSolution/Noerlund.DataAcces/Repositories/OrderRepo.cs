using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Noerlund.DataAcces.Contexts;
using Noerlund.DataAcces.Mappers;
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

        public Task DeleteOrderAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateOrderAsync(Order ord)
        {
            throw new NotImplementedException();
        }

        public Order GetOrderByGuidId(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetAllOrders()
        {
            throw new NotImplementedException();
        }
    }
}
