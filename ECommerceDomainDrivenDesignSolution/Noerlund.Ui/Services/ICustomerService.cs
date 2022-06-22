using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Noerlund.Ui.Models;

namespace Noerlund.Ui.Services
{
    public interface ICustomerService
    {
        Task <CustomerModel> CreateCustomerAsync(CustomerModel cos);
        Task DeleteCustomerAsync(Guid id);
        Task UpdateCustomerAsync(CustomerModel cat);
        Task<CustomerModel> GetCustomerByGuidId(Guid id);
        Task<List<CustomerModel>> GetAllCustomer();
    }
}
