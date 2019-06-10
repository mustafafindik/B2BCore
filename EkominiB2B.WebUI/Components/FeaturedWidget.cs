using EkominiB2B.Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EkominiB2B.WebUI.Components
{
    public class FeaturedWidget : ViewComponent
    {
        private IProductService productService;

        public FeaturedWidget(IProductService productService)
        {
            this.productService = productService;
        }

        public IViewComponentResult Invoke()
        {
            var result = productService.GetAll().Where(d => d.IsFeatured == true).ToList();
            return View(result);
        }
    }


}
