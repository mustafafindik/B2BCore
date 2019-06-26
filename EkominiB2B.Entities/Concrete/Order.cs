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
             
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        public int AddressId { get; set; }
        public Address Address { get; set; }

        public DateTime OrderDate { get; set; }

        public double Total { get; set; }
        public double Shipping { get; set; }

        public int? OrderStatusId { get; set; }
        public OrderStatus OrderStatus { get; set; }



    }
}
