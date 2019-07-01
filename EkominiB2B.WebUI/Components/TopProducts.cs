using EkominiB2B.Business.Abstract;
using EkominiB2B.Entities.ViewModels;
using EkominiB2B.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EkominiB2B.WebUI.Components
{
    public class TopProducts : ViewComponent
    {
        private IProductService productService;
        private IOrderService orderService;

        public TopProducts(IProductService productService, IOrderService orderService)
        {
            this.productService = productService;
            this.orderService = orderService;
        }

        public IViewComponentResult Invoke(int? count)
        {                    
                return View(productService.GetTopProducts(count??6));        
        }
    }

  
}
