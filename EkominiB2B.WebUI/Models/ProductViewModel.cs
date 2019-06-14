using EkominiB2B.Entities;
using Sakura.AspNetCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EkominiB2B.WebUI.Models
{


    public class ProdcuctViewModel
    {
        public IPagedList<Product> Products { get; set; }
        public IEnumerable<Category> Categories { get; set; }

    }
}
