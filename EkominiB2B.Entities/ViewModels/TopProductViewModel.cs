using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EkominiB2B.Entities.ViewModels
{
    public class TopProductViewModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double? CurrentPrice { get; set; }
        public double? Discount { get; set; }
        public string ProdudctImage { get; set; }
        public int SaleCount { get; set; }
        public int SalePer { get; set; }

    }
}
