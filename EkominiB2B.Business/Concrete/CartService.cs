﻿using EkominiB2B.Business.Abstract;
using EkominiB2B.Entities;
using EkominiB2B.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EkominiB2B.Business.Concrete
{
    public class CartService : ICartService
    {
        public void AddToCart(Cart cart, Product product, int quantity)
        {
            CartLine cartLine = cart.CartLines.FirstOrDefault(c => c.Product.Id == product.Id);
            if (cartLine != null)
            {
                cartLine.Quantity++;
                return;
            }
         
            cart.CartLines.Add(new CartLine { Product = product, Quantity = quantity });
        }

        public void RemoveFromCart(Cart cart, int productId)
        {
            cart.CartLines.Remove(cart.CartLines.FirstOrDefault(c => c.Product.Id == productId));
        }

        public List<CartLine> List(Cart cart)
        {
            return cart.CartLines;
        }
    }
}
