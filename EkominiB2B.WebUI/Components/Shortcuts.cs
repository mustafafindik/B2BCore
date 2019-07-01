using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EkominiB2B.WebUI.Components
{
    public class Shortcuts:ViewComponent
    {
   
        public IViewComponentResult Invoke()
        {         
            return View();
        }
    }


}
