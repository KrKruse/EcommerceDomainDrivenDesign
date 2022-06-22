using Noerlund.Ui.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Noerlund.Ui.Extensions;

namespace Noerlund.Ui.Services
{
    public class OrderService : IOrderService
    {
        private readonly HttpClient _client;

        public OrderService(HttpClient client)
        {
            _client = client;
        }
        public async Task<OrderModel> CreateOrderAsync(OrderModel order)
        {
            var response = await _client.PostAsJson($"/api/v1/Order", order);
            if (response.IsSuccessStatusCode)
                return await response.ReadContentAs<OrderModel>();
            else
            {
                throw new Exception("Something went wrong when calling api.");
            }
        }

        public Task DeleteOrderAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<OrderModel>> GetAllOrders()
        {
            throw new NotImplementedException();
        }

        public Task<OrderModel> GetOrderByGuidId(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateOrderAsync(OrderModel order)
        {
            throw new NotImplementedException();
        }
    }
}
