using EkominiB2B.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EkominiB2B.Entities
{
    public class Product:BaseEntity
    {

        public string ProductName { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
