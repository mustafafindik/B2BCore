using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EkominiB2B.Business.Abstract;
using EkominiB2B.Entities.Concrete;
using EkominiB2B.WebUI.Services;
using Microsoft.AspNetCore.Mvc;

namespace EkominiB2B.WebUI.Controllers
{
    public class CartController : Controller
    {
        private ICartSessionService _cartSessionService;
        private ICartService _cartService;
        private IProductService _productService;

        public CartController(
            ICartSessionService cartSessionService,
            ICartService cartService,
            IProductService productService)
        {
            _cartSessionService = cartSessionService;
            _cartService = cartService;
            _productService = productService;
        }

        public ActionResult AddToCart(int productId, int quantity = 1, int quantityUp = 0, string currentContreller = "Cart", string currentAction = "OrderDetails")
        {
            var productToBeAdded = _productService.Get(productId);

            var cart = _cartSessionService.GetCart();

            _cartService.AddToCart(cart, productToBeAdded, quantity, quantityUp);

            _cartSessionService.SetCart(cart);


            return RedirectToAction(currentAction, currentContreller);
        }

        public ActionResult OrderDetails()
        {
            var cart = _cartSessionService.GetCart();
            Cart newCard = new Cart();
            newCard = cart;
            return View(newCard);
        }

        public ActionResult Remove(int productId, string currentContreller = "Cart", string currentAction = "OrderDetails")
        {
            var cart = _cartSessionService.GetCart();
            _cartService.RemoveFromCart(cart, productId);
            _cartSessionService.SetCart(cart);

            return RedirectToAction(currentAction, currentContreller);
        }

        public ActionResult RemoveCart()
        {
            var cart = _cartSessionService.GetCart();
            _cartService.RemoveCart(cart);
            _cartSessionService.SetCart(cart);
            return RedirectToAction("OrderDetails", "Cart");
        }

    }
}
