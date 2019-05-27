using EkominiB2B.Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EkominiB2B.WebUI.Components
{
    public class LatestProducts : ViewComponent
    {
        private IProductService productService;

        public LatestProducts(IProductService productService)
        {
            this.productService = productService;
        }

        public IViewComponentResult Invoke()
        {
            var result = productService.GetAll().OrderByDescending(d=>d.UpdatedAt).Take(6).ToList();
            return View(result);
        }
    }


}
