using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EkominiB2B.Business.Abstract;
using EkominiB2B.Entities.Concrete;
using EkominiB2B.WebUI.Models;
using EkominiB2B.WebUI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EkominiB2B.WebUI.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {
        private ICartSessionService _cartSessionService;
        private ICartService _cartService;
        private IOrderService _orderService;
        private readonly UserManager<ApplicationUser> _userManager;
        private IAddressService _addressService; 

        public OrderController(ICartSessionService cartSessionService, ICartService cartService, IOrderService orderService, UserManager<ApplicationUser> userManager, IAddressService addressService)
        {
            _cartSessionService = cartSessionService;
            _cartService = cartService;
            _orderService = orderService;
            _userManager = userManager;
            _addressService = addressService;
        }


        public async Task<IActionResult> OrderView()
        {
            var user = await _userManager.GetUserAsync(User).ConfigureAwait(false);
            OrderViewModel model = new OrderViewModel();
            Cart newCard = _cartSessionService.GetCart();
            model.Cart = newCard;
            model.Addresses = _addressService.GetByUserId(user.Id);
            return View(model);

        }

        public IActionResult MakeDefault(int Id)
        {
            _addressService.MakeDefault(Id);
            return RedirectToAction("OrderView");
        }

        public async Task<IActionResult> Checkout(double ship)
        {
            var user = await _userManager.GetUserAsync(User).ConfigureAwait(false);
            Cart newCard = _cartSessionService.GetCart();
            var order = _orderService.CartToOrder(newCard, ship, user);
            _orderService.Add(order);

            var cart = _cartSessionService.GetCart();
            _cartService.RemoveCart(cart);
            _cartSessionService.SetCart(cart);

            return View();
        }
    }
}