using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EkominiB2B.Business.Abstract;
using EkominiB2B.Entities;
using EkominiB2B.Entities.Concrete;
using EkominiB2B.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Sakura.AspNetCore;

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

        public IActionResult Index(double? minPrice, double? maxPrice,string OrderBy, int? categoryId = 0, int page = 1, int PageSize = 12)
        {
          

            var products = productService.GetAll("Category");

            ViewBag.Max = (int)Math.Ceiling(Convert.ToDecimal(products.Max(d=> d.Price - (d.Price * d.DiscountRatio))??0));
            ViewBag.Min = (int)Math.Floor(Convert.ToDecimal(products.Min(d => d.Price - (d.Price * d.DiscountRatio)) ?? 0));

            ViewBag.minPrice = minPrice ?? ViewBag.Min;
            ViewBag.maxPrice = maxPrice ?? ViewBag.Max;
            ViewBag.categoryId = categoryId;
            ViewBag.OrderBy = OrderBy??"default";
            ViewBag.page = page;
            ViewBag.PageSize = PageSize;

 
            ViewBag.ProductCount = products.Count();

            ProdcuctViewModel model = new ProdcuctViewModel();
            model.Categories = categoryService.GetAll().ToList();
            var x = products
                .Where(d => minPrice == null ? true : (d.Price - (d.Price * d.DiscountRatio)) >= minPrice)
                .Where(d => maxPrice == null ? true : (d.Price - (d.Price * d.DiscountRatio)) <= maxPrice)
                .Where(d => categoryId == 0 ? true : d.CategoryId == categoryId);
              //  

            model.Products = Ordering(x, OrderBy).ToPagedList(PageSize, page);

            return View(model);
        }

        private IEnumerable<Product> Ordering(IEnumerable<Product> x, string orderBy)
        {
            if (orderBy=="new")
            {
                return x.OrderByDescending(d => d.UpdatedAt);
            }
            else if (orderBy== "Name")
            {
                return x.OrderBy(d => d.ProductName);
            }
            else if (orderBy == "decrease")
            {
                return x.OrderByDescending(d => (d.Price - (d.Price * d.DiscountRatio)));
            }
            else if (orderBy == "increase")
            {
                return x.OrderBy(d => (d.Price - (d.Price * d.DiscountRatio)));
            }
            else
            {
                return x;
            }

           
        }

        public IActionResult Details(int Id)
        {
            var product = productService.Get(Id);
            return View(product);
        }
    }
}