using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EkominiB2B.Business.Abstract;
using EkominiB2B.WebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace EkominiB2B.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductService productService;
        private ICategoryService categoryService;

        public ProductController(IProductService productService, ICategoryService categoryService)
        {
            this.productService = productService;
            this.categoryService = categoryService;
        }

        public IActionResult Index(decimal? minPrice,decimal? maxPrice,string OrderBy, int? categoryId = 0)
        {
            ViewBag.minPrice = minPrice;
            ViewBag.maxPrice = maxPrice;
            ViewBag.categoryId = categoryId;
            ViewBag.OrderBy = OrderBy;

            ProdcuctViewModel model = new ProdcuctViewModel();
            model.Categories = categoryService.GetAll().ToList();
            model.Products = productService.GetAll("Category").ToList();
            return View(model);
        }
    }
}