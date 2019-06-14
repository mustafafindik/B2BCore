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
using Sakura.AspNetCore;

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

     
        public IActionResult Query(string q, int categoryId=0, int page = 1, int PageSize = 8)
        {
            var products = productService.GetAll("Category").Where(d => categoryId == 0 ? true : d.CategoryId == categoryId).ToList();
     

            var qq = q.ToLower();
            string[] terms = qq.Split(' ');
            foreach (var term in terms)
            {
                products = products.Where(r => r.ProductName.ToLower().Contains(term) || r.Category.CategoryName.ToLower().Contains(term)).ToList();
            }
            ViewBag.Query = q;
            ViewBag.Total = products.Count();
            ViewBag.categoryId = categoryId;
            ViewBag.page = page;
            ViewBag.PageSize = PageSize;

            var result = products.ToPagedList(PageSize, page);

            return View(result);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
