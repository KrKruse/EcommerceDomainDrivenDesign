using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Blazored.LocalStorage;
using Blazored.Toast;
using Microsoft.AspNetCore.Components;
using Noerlund.Ui.BasketServices;
using Noerlund.Ui.BasketServices;
using Noerlund.Ui.Services;

namespace Noerlund.Ui
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:44032") });

            builder.Services.AddScoped<ICategoryService, CategoryService>();
            builder.Services.AddScoped<IProductService, ProductService>();
            builder.Services.AddScoped<IBasketService, BasketService>();
            builder.Services.AddScoped<ICustomerService, CustomerService>();
            builder.Services.AddScoped<IOrderService, OrderService>();
            builder.Services.AddScoped<IOrderItemService, OrderItemService>();

            builder.Services.AddBlazoredLocalStorage();
            builder.Services.AddBlazoredToast();

            await builder.Build().RunAsync();
        }
    }
}
