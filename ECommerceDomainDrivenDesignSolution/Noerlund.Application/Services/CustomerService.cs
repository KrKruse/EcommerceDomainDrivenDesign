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
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepo _repo;

        public CustomerService(ICustomerRepo repo)
        {
            _repo = repo;
        }
        public async Task CreateCustomerAsync(CreateCustomerDto cos)
        {
            var customer = new Customer(cos.CustomerId, cos.CustomerName, cos.CustomerEmail, cos.PhoneNumber);
            await _repo.CreateCustomerAsync(customer);
        }

        public async Task DeleteCustomerAsync(Guid id)
        {
            var cos = _repo.GetCustomerByGuidId(id);

            await _repo.DeleteCustomerAsync(id);
        }

        public async Task UpdateCustomerAsync(CustomerDtoRequest cat)
        {
            var toBeUpdated = new Customer(cat.CustomerId, cat.CustomerName, cat.CustomerEmail, cat.PhoneNumber);

            await _repo.UpdateCustomerAsync(toBeUpdated);
        }

        public Customer GetCustomerByGuidId(Guid id)
        {
            var customer = _repo.GetCustomerByGuidId(id);

            return customer;
        }

        public List<Customer> GetAllCustomer()
        {
            var dtos = _repo.GetAllCustomer();

            return dtos;
        }
    }
}
