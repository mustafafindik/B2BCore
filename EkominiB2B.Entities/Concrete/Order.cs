using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EkominiB2B.Entities.Concrete
{
    public class Order : BaseEntity
    {

        public Order()
        {
            orderLine = new List<OrderLine>();
        }
        public List<OrderLine> orderLine { get; set; }
    
        public double? Total
        {
            get { return orderLine.Where(d => d.OrderId == Id).Sum(c => (c.Product.Price - (c.Product.Price * c.Product.DiscountRatio)) * c.Quantity); }                   
        }

        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        public int AddressId { get; set; }
        public Address Address { get; set; }

        public DateTime OrderDate { get; set; }

    
    }
}
