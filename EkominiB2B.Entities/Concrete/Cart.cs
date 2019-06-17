using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EkominiB2B.Entities.Concrete
{
    public class Cart
    {
        public Cart()
        {
            CartLines = new List<CartLine>();
        }
        public List<CartLine> CartLines { get; set; }

        public double? Total
        {
            get { return CartLines.Sum(c => (c.Product.Price-(c.Product.Price*c.Product.DiscountRatio)) * c.Quantity); }
        }
    }
}
