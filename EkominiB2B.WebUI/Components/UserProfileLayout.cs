using EkominiB2B.DataAccess.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EkominiB2B.WebUI.Components
{
    public class UserProfileLayout : ViewComponent
    {
        private readonly IUserRepository _userRepository;
        public UserProfileLayout(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IViewComponentResult Invoke()
        {
            var user = _userRepository.GetByName(User.Identity.Name);
            return View(user);
        }

    }
}