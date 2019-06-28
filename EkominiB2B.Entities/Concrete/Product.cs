using EkominiB2B.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EkominiB2B.Entities
{
    public class Product:BaseEntity
    {

        public string ProductName { get; set; }

        public string ShortDescription { get; set; }

        public string Description { get; set; }

        public double? Price { get; set; }

        public string Image { get; set; }

        public double? DiscountRatio { get; set; }

        public bool IsActive { get; set; } = true;

        public bool IsFeatured { get; set; }

        public bool IsInSlider { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public List<OrderLine> orderLine { get; set; }
    }
}
