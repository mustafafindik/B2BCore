using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EkominiB2B.Business.Abstract;
using EkominiB2B.Entities.Concrete;
using EkominiB2B.WebUI.Models.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EkominiB2B.WebUI.Controllers
{
    public class ManageController : Controller
    {
        private readonly IUserService userService;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        public ManageController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, IUserService userService)
        {
            _userManager = userManager;
            this.userService = userService;
            _signInManager = signInManager;
        }

        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(User).ConfigureAwait(false);
            return View(user);
        }

        public async Task<IActionResult> MyAdresses()
        {           
            return View();
        }

        public async Task<IActionResult> MyOrders()
        {
            return View();
        }

        public async Task<IActionResult> EditProfile()
        {
            var user = await _userManager.GetUserAsync(User).ConfigureAwait(false);
            return View(user);
        }

        [HttpPost]
        public IActionResult EditProfile(ApplicationUser user, IFormFile uploadFile)
        {
            if (ModelState.IsValid)
            {
                userService.UpdateUser(user, uploadFile);
                return RedirectToAction("Index");
            }

            return View(user);
        }

        public async Task<IActionResult> ChangePassword()
        {
            var user = await _userManager.GetUserAsync(User).ConfigureAwait(false);
            if (user == null)
            {
                throw new ApplicationException($"Kimliğe sahip kullanıcı yüklenemedi.");
            }
            var model = new ChangePasswordViewModel();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> ChangePassword(ChangePasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await _userManager.GetUserAsync(User).ConfigureAwait(false);
            if (user == null)
            {
                throw new ApplicationException($"Kimliğe sahip kullanıcı yüklenemedi ");
            }

            var changePasswordResult = await _userManager.ChangePasswordAsync(user, model.OldPassword, model.NewPassword).ConfigureAwait(false);
            if (!changePasswordResult.Succeeded)
            {
                foreach (var error in changePasswordResult.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
                return View(model);
            }

            await _signInManager.SignInAsync(user, isPersistent: false).ConfigureAwait(false);
            return RedirectToAction(nameof(Index));
        }



    }
}