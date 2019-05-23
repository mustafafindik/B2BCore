using EkominiB2B.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EkominiB2B.Entities
{
    public class Category:BaseEntity
    {
       
        public string CategoryName { get; set; }
        List<Product> Products { get; set; }
        
    }
}
