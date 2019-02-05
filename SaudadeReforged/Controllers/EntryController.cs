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
    [Authorize]
    public class EntryController : Controller
    {
        // GET: Entry
        public ActionResult Index()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new EntryService(userId);
            var model = service.GetEntries();
            return View(model);
        }
        // GET: Entry Action
        public ActionResult Create()
        {
            return View();
        }

        // POST: Entry Action
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EntryCreate model)
        {
            if (!ModelState.IsValid) return View(model);

            var service = CreateEntryService();

            if (service.CreateEntry(model))
            {
                TempData["SaveResult"] = "Your entry was added to your collection.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Entry could not be created.");

            return View(model);
        }

        // READ: Entry Action Details
        public ActionResult Details(int id)
        {
            var svc = CreateEntryService();
            var model = svc.GetEntryById(id);
            return View(model);
        }

        private EntryService CreateEntryService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new EntryService(userId);
            return service;
        }

        // EDIT: Entry Action Update
        public ActionResult Edit(int id)
        {
            var service = CreateEntryService();
            var detail = service.GetEntryById(id);
            var model =
                new EntryEdit
                {
                    EntryId = detail.EntryId,
                    Title = detail.Title,
                    Topic = detail.Topic,
                    Content = detail.Content,
                    Tag = detail.Tag
                };
            return View(model);
        }

        // EDIT: Entry Action View Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, EntryEdit model)
        {
            if (!ModelState.IsValid) return View(model);

            if(model.EntryId != id)
            {
                ModelState.AddModelError("", "Id Mismatch!");
                return View(model);
            }

            var service = CreateEntryService();

            if(service.UpdateEntry(model))
            {
                TempData["SaveResult"] = "Your Entry was updated.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Your Entry failed to update.");
            return View(model);
        }

        // DELETE: Entry Action Destroy

        [ActionName("Delete")]
        public ActionResult Delete(int id)
        {
            var svc = CreateEntryService();
            var model = svc.GetEntryById(id);

            return View(model);
        }

        // DELETE: Entry Action View Method

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteEntry(int id)
        {
            var service = CreateEntryService();

            service.DeleteEntry(id);

            TempData["SaveResult"] = "Your Entry has been removed from your collection";

            return RedirectToAction("Index");
        }
    }
}