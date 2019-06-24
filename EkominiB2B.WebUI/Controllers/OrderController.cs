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
        private IProductService _productService;
        private readonly UserManager<ApplicationUser> _userManager;
        private IAddressService _addressService; 

        public OrderController(ICartSessionService cartSessionService, IProductService productService, UserManager<ApplicationUser> userManager, IAddressService addressService)
        {
            _cartSessionService = cartSessionService;
            _productService = productService;
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
    }
}