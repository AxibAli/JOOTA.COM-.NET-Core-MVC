﻿using Joota.com.Data.Cart;
using Joota.com.Data.Services;
using Joota.com.Data.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Joota.com.Controllers
{
    public class OrdersController : Controller
    {
        private readonly IShoeService _shoeService;
        private readonly ShoppingCart  _shoppingCart;
        private readonly IOrderService _orderService;
        public OrdersController(IShoeService shoeService, ShoppingCart shoppingCart, IOrderService orderService)
        {
            _shoeService = shoeService;
            _shoppingCart = shoppingCart;
            _orderService = orderService;
        }

        public async Task<IActionResult> Index()
        {
            string userId = "";
            var orders = await _orderService.GetOrdersByUserIdAsync(userId);
            return View(orders);
        }

        public IActionResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItem = items;
            var response = new ShoppingCartVM()
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };
            return View(response);
        }

        public async Task <IActionResult> AddItemToShoppingCart(int id)
        {
            var item = await _shoeService.GetShoesByIdAsync(id);

            if( item != null)
            {
                _shoppingCart.AddItemToCart(item);
            }
            return RedirectToAction(nameof(ShoppingCart));
        }

        public async Task<IActionResult> RemoveItemFromShoppingCart(int id)
        {
            var item = await _shoeService.GetShoesByIdAsync(id);

            if (item != null)
            {
                _shoppingCart.RemoveItemFromCart(item);
            }
            return RedirectToAction(nameof(ShoppingCart));
        }

        public async Task<IActionResult> CompleteOrder()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            string userId = "";
            string userEmailAddress = "";

            await _orderService.StoreOrderAsync(items, userId, userEmailAddress);
            await _shoppingCart.ClearShoppingCartAsync();
            return View("OrderCompleted");
        }
    }

}
