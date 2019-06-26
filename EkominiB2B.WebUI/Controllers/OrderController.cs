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
            model.Shipping = 0;
            ViewBag.BestShipping = 5;
            return View(model);

        }

        public IActionResult MakeDefault(int Id)
        {
            _addressService.MakeDefault(Id);
            return RedirectToAction("OrderView");
        }

        public async Task<IActionResult> Checkout(double? ship)
        {
            try
            {
                var user = await _userManager.GetUserAsync(User).ConfigureAwait(false);
                Cart newCard = _cartSessionService.GetCart();
                var order = _orderService.CartToOrder(newCard, ship ?? 0, user);
                _orderService.Add(order);
                int orderid = order.Id;
                var cart = _cartSessionService.GetCart();
                _cartService.RemoveCart(cart);
                _cartSessionService.SetCart(cart);
                 Guid token = Guid.NewGuid();
                return RedirectToAction("OrderSuccess","Order", new { token = token , Id = orderid });
            }
            catch (Exception e)
            {
                return RedirectToAction("OrderError", "Order", new { message = e.Message});
            }                      
        }

        public IActionResult OrderSuccess(Guid token, int Id)
        {
            var order = _orderService.Get(Id);
            return View(order);
        }


        public IActionResult OrderError(string message)
        {
            ViewBag.message = message;
            return View();
        }
    }
}