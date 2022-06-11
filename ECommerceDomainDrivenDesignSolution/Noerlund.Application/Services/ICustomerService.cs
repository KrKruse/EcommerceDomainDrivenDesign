using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Noerlund.Application.Models;
using Noerlund.Domain.Models;

namespace Noerlund.Application.Services
{
    public interface ICustomerService
    {
        Task CreateCustomerAsync(CreateCustomerDto cos);
        Task DeleteCustomerAsync(Guid id);
        Task UpdateCustomerAsync(CustomerDtoRequest cat);
        Customer GetCustomerByGuidId(Guid id);
        List<Customer> GetAllCustomer();
    }
}
