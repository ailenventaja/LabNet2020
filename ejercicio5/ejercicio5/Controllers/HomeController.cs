using Microsoft.Ajax.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entities;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http.Cors;

namespace ejercicio5.Controllers
{
    public class HomeController : Controller
    {

        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}