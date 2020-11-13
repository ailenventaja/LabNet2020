using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entities;
using Logic;

namespace ejercicio5.Controllers
{
    public class LocationsController : Controller
    {
        // GET: Locations
        public ActionResult Index()
        {
            var logic = new LocationsLogic();
            var locations = logic.GetAll();
            if (TempData["Message"] != null)
                ViewBag.Message = TempData["Message"].ToString();
            return View(locations);
        }
        public ActionResult Insert()
        {
            return View();
        }

        public ActionResult Update(int id)
        {
            var logic = new LocationsLogic();
            var location = logic.GetOne(id);
            return View(location);
        }


        [HttpPost]
        public ActionResult Insert(LOCATIONS location)
        {
            var logic = new LocationsLogic();
            var locationEntity = new LOCATIONS();
            locationEntity.CITY = location.CITY;
            try
            {
                logic.Insert(locationEntity);
                TempData["Message"] = "New location added successfully";
            }
            catch (Exception e)
            {
                TempData["Message"] = $"Error adding location. {e.Message}";
            }
            return RedirectToAction("index");
        }


        public ActionResult Delete(int id)
        {
            var logic = new LocationsLogic();
            try
            {
                logic.Delete(id);
                TempData["Message"] = "Location deleted successfully";
            }
            catch (Exception e)
            {
                TempData["Message"] = $"Error deleting location. {e.Message}";
            }
            return RedirectToAction("index");
        }


        [HttpPost]
        public ActionResult Update(LOCATIONS location)
        {
            var logic = new LocationsLogic();
            var locationEntity = logic.GetOne(location.ID);
            if (location.CITY != null)
                locationEntity.CITY = location.CITY;
            try
            {
                logic.Update(locationEntity);
                TempData["Message"] = "Location updated successfully";
            }
            catch (Exception e)
            {
                TempData["Message"] = $"Error updating location. {e.Message}";
            }
            return RedirectToAction("index");
        }
    }
}