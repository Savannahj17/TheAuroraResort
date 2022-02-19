using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheAuroraResort.Models;
using TheAuroraResort.Services;

namespace TheAuroraResort.Controllers
{
    public class ReservationController : Controller
    {
        // GET: Reservation
        public ActionResult Index()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new ReservationService(userId);
            var model = service.GetReservations();

            return View(model);
        }

        public ActionResult Create()
        {
            return View(new ReservationCreate());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ReservationCreate model)
        {
            if (ModelState.IsValid)
            {
                return View(model);
            }

            var service = CreateReservationService();

            if (service.CreateReservation(model))
            {
                TempData["SaveResult"] = "Your reservation was successfully created.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Your reservation could not be created. Please try again.");

            return View(model);
        }

        private ReservationService CreateReservationService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new ReservationService(userId);
            return service;
        }

        public ActionResult Details(int ReservationId)
        {
            var svc = CreateReservationService();
            var model = svc.GetReservationById(ReservationId);

            return View(model);
        }

        public ActionResult Edit(int ReservationId)
        {
            var service = CreateReservationService();
            var detail = service.GetReservationById(ReservationId);
            var model = new ReservationEdit
            {
                ReservationId = detail.ReservationId,
                PartySize = detail.PartySize,
                ActivityName = detail.ActivityName,
                ArrivalDateTime = detail.ArrivalDateTime,
                DepartureDateTime = detail.DepartureDateTime
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Edit(int ReservationId, ReservationEdit model)
        {
            if (ModelState.IsValid)
                return View(model);

            if(model.ReservationId != ReservationId)
            {
                ModelState.AddModelError("", "These Id's do not match.");
                return View(model);
            }

            var service = CreateReservationService();

            if (service.UpdateReservation(model))
            {
                TempData["SaveResult"] = "Your reservation has been updated!";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Your reservation could not be updated at this time. Please try again later or try calling 1-800-555-5555. We apologize for the inconvenience.");
            return View();
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeletePost(int ReservationId)
        {
            var service = CreateReservationService();
            service.DeleteReservation(ReservationId);
            TempData["SaveResult"] = "Your reservation has been successfully deleted.";
            return RedirectToAction("Index");
        }

    }
}