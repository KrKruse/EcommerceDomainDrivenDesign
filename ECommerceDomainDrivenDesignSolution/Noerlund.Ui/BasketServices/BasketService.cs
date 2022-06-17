using Noerlund.Ui.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazored.LocalStorage;
using Blazored.Toast.Services;
using Noerlund.Ui.Services;

namespace Noerlund.Ui.BasketServices
{
    public class BasketService : IBasketService
    {
        private readonly ILocalStorageService _localStorage;
        private readonly IToastService _toastService;
        private readonly IProductService _productService;


        public BasketService(ILocalStorageService localStorage, IToastService toastService, IProductService productService)
        {
            _localStorage = localStorage;
            _toastService = toastService;
            _productService = productService;
        }
        public event Action OnChange;
        public async Task AddToBasket(ProductModel product)
        {
            var basket = await _localStorage.GetItemAsync<List<ProductModel>>("basket");
            if (basket == null)
            {
                basket = new List<ProductModel>();
            }

            basket.Add(product);
            await _localStorage.SetItemAsync("basket", basket);

            var prod = await _productService.GetProductByGuidId(product.ProductId);
            _toastService.ShowSuccess(prod.ProductName, "tilføjet til Kurv:");

            OnChange.Invoke();
        }

        public async Task DeleteItem(ProductModel item)
        {
            var basket = await _localStorage.GetItemAsync<List<ProductModel>>("basket");
            if (basket == null)
            {
                return;
            }

            var cartItem = basket.Find(x => x.ProductId == item.ProductId);
            basket.Remove(cartItem);

            await _localStorage.SetItemAsync("basket", basket);
            OnChange.Invoke();
        }

        public async Task EmptyCart()
        {
            await _localStorage.RemoveItemAsync("basket");
            OnChange.Invoke();
        }

        public async Task<List<ProductModel>> GetBasketItems()
        {
            var basket = await _localStorage.GetItemAsync<List<ProductModel>>("basket");
            if (basket == null)
            {
                return new List<ProductModel>();
            }
            return basket;
        }
    }
}
