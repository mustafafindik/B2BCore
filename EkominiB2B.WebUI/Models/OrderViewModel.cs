using EkominiB2B.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EkominiB2B.WebUI.Models
{
    public class OrderViewModel
    {
        public IEnumerable<Address> Addresses { get; set; }
        public Cart Cart { get; set; }
    }
}
