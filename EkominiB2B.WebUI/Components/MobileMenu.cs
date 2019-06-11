using EkominiB2B.Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EkominiB2B.WebUI.Components
{
    public class MobileMenu : ViewComponent
    {
        private ICategoryService categoryService;

        public MobileMenu(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        public IViewComponentResult Invoke()
        {
            var result = categoryService.GetAll().ToList();
            return View(result);
        }
    }


}
