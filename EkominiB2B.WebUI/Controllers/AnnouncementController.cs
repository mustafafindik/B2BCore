using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EkominiB2B.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace EkominiB2B.WebUI.Controllers
{
    public class AnnouncementController : Controller
    {
        private IAnnouncementService announcementService;

        public AnnouncementController(IAnnouncementService announcementService)
        {
            this.announcementService = announcementService;
        }

        public IActionResult Index()
        {
            var all = announcementService.GetAll("ApplicationUser").ToList();
            return View(all);
        }

        public IActionResult Details(int Id)
        {
            var announcement = announcementService.Get(Id);
            return View(announcement);
        }
    }
}