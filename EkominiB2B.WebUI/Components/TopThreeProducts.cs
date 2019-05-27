using EkominiB2B.Business.Abstract;
using EkominiB2B.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EkominiB2B.WebUI.Components
{
    public class TopThreeProducts : ViewComponent
    {
        private IProductService productService;

        public TopThreeProducts(IProductService productService)
        {
            this.productService = productService;
        }

        public IViewComponentResult Invoke()
        {
            TopThreeProductViewModel model = new TopThreeProductViewModel();
            model.Featured = productService.GetAll().Where(d=>d.IsFeatured==true).OrderByDescending(d => d.UpdatedAt).Take(3).ToList();
            model.New = productService.GetAll().OrderByDescending(d => d.UpdatedAt).Take(3).ToList();
            model.Hot = productService.GetAll().Take(3).ToList();
            model.Sale = productService.GetAll().Where(d=>d.DiscountRatio>0).OrderByDescending(d => d.UpdatedAt).Take(3).ToList();

            return View(model);
        }
    }


}
