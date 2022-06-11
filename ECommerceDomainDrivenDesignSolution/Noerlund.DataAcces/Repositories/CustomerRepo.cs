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
    public class CustomerRepo : ICustomerRepo
    {
        private readonly NoerlundContext _context;

        public CustomerRepo(NoerlundContext context)
        {
            _context = context;
        }

        public async Task CreateCustomerAsync(Customer cos)
        {
            var dto = Mapper.Map(cos);
            _context.Add(dto);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCustomerAsync(Guid id)
        {
            var toRemove = Find(id);

            _context.CustomerDtos.Remove(toRemove);

            await _context.SaveChangesAsync();
        }

        public List<Customer> GetAllCustomer()
        {
            var dtos = _context.CustomerDtos.ToList().AsQueryable();
            return Mapper.Map(dtos);
        }

        public Customer GetCustomerByGuidId(Guid id)
        {
            var cos = _context.CustomerDtos.AsNoTracking().FirstOrDefault(f => f.CustomerId.Equals(id));
            if (cos == null)
                return null;
            return Mapper.Map(cos);
        }

        public async Task UpdateCustomerAsync(Customer cos)
        {
            CustomerDto dto = _context.CustomerDtos.Find(cos.CustomerId);

            dto.CustomerId = cos.CustomerId;
            dto.CustomerEmail = cos.CustomerEmail;
            dto.CustomerName = cos.CustomerName;
            dto.PhoneNumber = cos.PhoneNumber;

            await _context.SaveChangesAsync();
        }

        private CustomerDto Find(Guid id)
        {
            return _context.CustomerDtos.Find(id);
        }
    }
}
