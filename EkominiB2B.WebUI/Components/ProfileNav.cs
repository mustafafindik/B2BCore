using EkominiB2B.Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EkominiB2B.WebUI.Components
{
    public class ProfileNav : ViewComponent
    {
        private readonly IUserService _userService;
        public ProfileNav(IUserService userService)
        {
            _userService = userService;
        }

        public IViewComponentResult Invoke()
        {
            var user = _userService.GetByName(User.Identity.Name);
            return View(user);
        }

    }
}