using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Noerlund.Ui.Extensions;
using Noerlund.Ui.Models;

namespace Noerlund.Ui.Services
{
    public class OrderItemService : IOrderItemService
    {
        private readonly HttpClient _client;

        public OrderItemService(HttpClient client)
        {
            _client = client;
        }
        public async Task<OrderItemModel> CreateOrderItemAsync(OrderItemModel orderItem)
        {
            var response = await _client.PostAsJson($"/api/v1/Orderitem", orderItem);
            if (response.IsSuccessStatusCode)
                return await response.ReadContentAs<OrderItemModel>();
            else
            {
                throw new Exception("Something went wrong when calling api.");
            }
        }

        public Task DeleteOrderItemAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateOrderItemAsync(OrderItemModel orderItem)
        {
            throw new NotImplementedException();
        }

        public Task<OrderItemModel> GetOrderItemByGuidId(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<OrderModel>> GetAllOrderItemsByOrderId(Guid orderId)
        {
            throw new NotImplementedException();
        }
    }
}
