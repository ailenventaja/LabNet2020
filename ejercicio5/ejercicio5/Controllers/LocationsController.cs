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
            logic.Insert(locationEntity);
            return RedirectToAction("index");
        }


        public ActionResult Delete(int id)
        {
            var logic = new LocationsLogic();
            logic.Delete(id);
            return RedirectToAction("index");
        }


        [HttpPost]
        public ActionResult Update(LOCATIONS location)
        {
            var logic = new LocationsLogic();
            var locationEntity = logic.GetOne(location.ID);
            if (location.CITY != null)
                locationEntity.CITY = location.CITY;
            logic.Update(locationEntity);
            return RedirectToAction("index");
        }
    }
}