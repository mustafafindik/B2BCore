using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EkominiB2B.WebUI.Models;
using EkominiB2B.Business.Abstract;
using EkominiB2B.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EkominiB2B.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private IProductService productService;
        private ICategoryService categoryService;

        public HomeController(IProductService productService, ICategoryService categoryService)
        {
            this.productService = productService;
             this.categoryService = categoryService;
        }

        public IActionResult Index()
        {
            ViewData["Category"] = new SelectList(categoryService.GetAll(), "Id", "CategoryName");

            return View();
        }



        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
