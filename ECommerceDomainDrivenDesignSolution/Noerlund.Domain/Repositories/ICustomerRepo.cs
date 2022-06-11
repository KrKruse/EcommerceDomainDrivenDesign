using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Noerlund.Domain.Models;

namespace Noerlund.Domain.Repositories
{
    public interface ICustomerRepo
    {
        Task CreateCustomerAsync(Customer cos);
        Task DeleteCustomerAsync(Guid id);
        Task UpdateCustomerAsync(Customer cos);
        Customer GetCustomerByGuidId(Guid id);
        List<Customer> GetAllCustomer();
    }
}
