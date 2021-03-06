﻿using EkominiB2B.Entities;
using EkominiB2B.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EkominiB2B.Business.Abstract
{
    public interface ICartService
    {
        void AddToCart(Cart cart, Product product, int quantity, int quantityUp);
        void RemoveFromCart(Cart cart, int productId);
        void RemoveCart(Cart cart);
        List<CartLine> List(Cart cart);
    }
}
