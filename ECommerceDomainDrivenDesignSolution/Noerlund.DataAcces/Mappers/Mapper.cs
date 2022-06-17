using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Noerlund.DataAcces.Models;
using Noerlund.Domain.Models;

namespace Noerlund.DataAcces.Mappers
{
    public static class Mapper
    {
        public static ProductDto Map(Product product)
        {
            return new ProductDto
            {
                ProductId = product.ProductId,
                Pris = product.Pris,
                    ProductName = product.ProductName,
                Description = product.Description,
                CategoryId = product.CategoryId
            };
        }
        public static Product Map(ProductDto dto)
        {
            var product = new Product(dto.ProductId, dto.Pris, dto.ProductName, dto.Description, dto.CategoryId);
            return product;
        }
        public static List<Product> Map(IQueryable<ProductDto> dtos)
        {
            var types = new List<Product>();
            foreach (var d in dtos)
            {
                var type = new Product(d.ProductId, d.Pris, d.ProductName, d.Description, d.CategoryId);

                types.Add(type);
            }

            return types;
        }

        public static CategoryDto Map(Category category)
        {
            return new CategoryDto
            {
                CategoryId = category.CategoryId,
                CategoryName = category.CategoryName
            };
        }
        public static Category Map(CategoryDto dto)
        {
            var category = new Category(dto.CategoryId, dto.CategoryName);
            return category;
        }

        public static List<Category> Map(IQueryable<CategoryDto> dtos)
        {
            var types = new List<Category>();
            foreach (var d in dtos)
            {
                var type = new Category(d.CategoryId, d.CategoryName);

                types.Add(type);
            }

            return types;
        }

        public static CustomerDto Map(Customer customer)
        {
            return new CustomerDto()
            {
                CustomerId = customer.CustomerId,
                CustomerName = customer.CustomerName,
                CustomerEmail = customer.CustomerEmail,
                PhoneNumber = customer.PhoneNumber
            };
        }

        public static Customer Map(CustomerDto dto)
        {
            var customer = new Customer(dto.CustomerId, dto.CustomerName, dto.CustomerEmail, dto.PhoneNumber);
            return customer;
        }

        public static List<Customer> Map(IQueryable<CustomerDto> dtos)
        {
            var types = new List<Customer>();
            foreach (var d in dtos)
            {
                var type = new Customer(d.CustomerId, d.CustomerName, d.CustomerEmail, d.PhoneNumber);

                types.Add(type);
            }

            return types;
        }
        public static OrderDto Map(Order order)
        {
            return new OrderDto()
            {
                OrderId = order.OrderId,
                TotalPris = order.TotalPris,
                CustomerId = order.CustomerId
            };
        }
        public static Order Map(OrderDto dto)
        {
            var order = new Order(dto.OrderId, dto.TotalPris, dto.CustomerId);
            return order;
        }
        public static List<Order> Map(IQueryable<OrderDto> dtos)
        {
            var types = new List<Order>();
            foreach (var d in dtos)
            {
                var type = new Order(d.OrderId, d.TotalPris, d.CustomerId);

                types.Add(type);
            }

            return types;
        }
        public static OrderItemDto Map(OrderItem orderItem)
        {
            return new OrderItemDto()
            {
                OrderItemId = orderItem.OrderItemId,
                OrderId = orderItem.OrderId,
                ProductId = orderItem.ProductId,
                Quantity = orderItem.Quantity
            };
        }
        public static OrderItem Map(OrderItemDto dto)
        {
            var orderItem = new OrderItem(dto.OrderItemId, dto.OrderId, dto.ProductId, dto.Quantity);
            return orderItem;
        }
        public static List<OrderItem> Map(IQueryable<OrderItemDto> dtos)
        {
            var types = new List<OrderItem>();
            foreach (var d in dtos)
            {
                var type = new OrderItem(d.OrderItemId, d.OrderId, d.ProductId, d.Quantity);

                types.Add(type);
            }

            return types;
        }
    }
}
