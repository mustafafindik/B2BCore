using EkominiB2B.Entities.Concrete;
using EkominiB2B.WebUI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EkominiB2B.WebUI.Components
{
    public class CartSummary : ViewComponent
    {
        private ICartSessionService _cartSessionService;

        public CartSummary(ICartSessionService cartSessionService)
        {
            _cartSessionService = cartSessionService;
        }


        public ViewViewComponentResult Invoke()
        {
            Cart Cart = new Cart();
            Cart = _cartSessionService.GetCart();          
            return View(Cart);
        }


    }
}

 