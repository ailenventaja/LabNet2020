using System;
using System.Collections.Generic;
using System.Linq;
using Entities;
using Logic;
using System.Web;
using System.Web.Mvc;

namespace ejercicio5.Controllers
{
    public class JobsController : Controller
    {
        // GET: Jobs
        public ActionResult Index()
        {
            var logic = new JobsLogic();
            var jobs = logic.GetAll();
            return View(jobs);
        }
        public ActionResult Insert()
        {
            return View();
        }

        public ActionResult Update()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Insert(JOBS job)
        {
            var logic = new JobsLogic();
            var jobEntity = new JOBS();
            jobEntity.ID = job.ID;
            jobEntity.JOB_NAME = job.JOB_NAME;
            logic.Insert(jobEntity);
            return RedirectToAction("index");
        }

        public ActionResult Delete(string id)
        {
            var logic = new JobsLogic();
            logic.Delete(id);
            return RedirectToAction("index");
        }


        [HttpPost]
        public ActionResult Update(string id, JOBS job)
        {
            var logic = new JobsLogic();
            var jobEntity = logic.GetOne(id);
            if (job.JOB_NAME != null)
                jobEntity.JOB_NAME = job.JOB_NAME;
            logic.Update(jobEntity);
            return RedirectToAction("index");
        }
    }
}