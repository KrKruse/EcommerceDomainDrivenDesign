using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Noerlund.Ui.Extensions;
using Noerlund.Ui.Models;

namespace Noerlund.Ui.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly HttpClient _client;

        public CustomerService(HttpClient client)
        {
            _client = client;
        }
        public async Task<CustomerModel> CreateCustomerAsync(CustomerModel cos)
        {
            var response = await _client.PostAsJson($"/api/v1/Customer", cos);
            if (response.IsSuccessStatusCode)
                return await response.ReadContentAs<CustomerModel>();
            else
            {
                throw new Exception("Something went wrong when calling api.");
            }
        }

        public Task DeleteCustomerAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCustomerAsync(CustomerModel cat)
        {
            throw new NotImplementedException();
        }

        public async Task<CustomerModel> GetCustomerByGuidId(Guid id)
        {
            var response = await _client.GetAsync($"/api/v1/Customer/{id}");
            return await response.ReadContentAs<CustomerModel>();
        }

        public Task<List<CustomerModel>> GetAllCustomer()
        {
            throw new NotImplementedException();
        }
    }
}
