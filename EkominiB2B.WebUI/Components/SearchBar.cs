using EkominiB2B.Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EkominiB2B.WebUI.Components
{
    public class SearchBar : ViewComponent
    {
        private ICategoryService categoryService;

        public SearchBar(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        public IViewComponentResult Invoke()
        {
            ViewData["Category"] = new SelectList(categoryService.GetAll(), "Id", "CategoryName");
            return View();
        }
    }


}
