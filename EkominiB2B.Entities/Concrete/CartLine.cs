using System;
using System.Collections.Generic;
using System.Text;

namespace EkominiB2B.Entities.Concrete
{
    public class CartLine
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
