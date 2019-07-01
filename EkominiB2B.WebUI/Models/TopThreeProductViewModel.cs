using EkominiB2B.Entities;
using EkominiB2B.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EkominiB2B.WebUI.Models
{
    public class TopThreeProductViewModel
    {
        public List<Product> Featured { get; set; }
        public List<Product> New { get; set; }
        public List<Product> Hot { get; set; }
        public List<Product> Sale { get; set; }
    }
}
