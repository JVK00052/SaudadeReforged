using Microsoft.AspNet.Identity;
using SaudadeReforged.Models;
using SaudadeReforged.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SaudadeReforged.Controllers
{
    public class BioController : Controller
    {
        // GET: Bio
        [Authorize]
        public ActionResult Index()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new BioService(userId);
            var model = service.GetBios();

            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        // CREATE: Bio
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(BioCreate model)
        {
            if (!ModelState.IsValid) return View(model);

            var service = CreateBioService();

            if (service.CreateBio(model))
            {
                TempData["SaveResult"] = "Your Bio has been added.";
            return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Your Bio could not bee added");

            return View(model);
        }

        public ActionResult Details(int id)
        {
            var svc = CreateBioService();
            var model = svc.GetBioById(id);

            return View(model);
        }

        private BioService CreateBioService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new BioService(userId);
            return service;
        }

    }
}