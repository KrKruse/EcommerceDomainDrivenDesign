using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Threading.Tasks;
using Noerlund.Ui.Models;

namespace Noerlund.Ui.BasketServices
{
    public interface IBasketService
    {
        event Action OnChange;
        Task AddToBasket(ProductModel product);
        Task<List<ProductModel>> GetBasketItems();
        Task DeleteItem(ProductModel item);
        Task EmptyCart();
    }
}
