using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EkominiB2B.Areas.Supplier.Controllers
{
    public class HomeController : Controller
    {
        [Area("Supplier")]
        public IActionResult Index()
        {
            return View();
        }
    }
}