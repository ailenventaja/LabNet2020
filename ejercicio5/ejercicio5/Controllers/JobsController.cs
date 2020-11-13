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
            if ( TempData["Message"] != null)
                ViewBag.Message = TempData["Message"].ToString();
            return View(jobs);
        }
        public ActionResult Insert()
        {
            return View();
        }
        public ActionResult Update(string id)
        {
            var logic = new JobsLogic();
            var job = logic.GetOne(id);
            return View(job);
        }


        [HttpPost]
        public ActionResult Insert(JOBS job)
        {
            var logic = new JobsLogic();
            var jobEntity = new JOBS();
            jobEntity.ID = job.ID;
            jobEntity.JOB_NAME = job.JOB_NAME;
            try
            {
                logic.Insert(jobEntity);
                TempData["Message"] = "New job added successfully";
            }
            catch (Exception e)
            {
                TempData["Message"] = $"Error adding new job. {e.Message}";
            }
            return RedirectToAction("index");
        }

        public ActionResult Delete(string id)
        {
            var logic = new JobsLogic();
            try
            {
                logic.Delete(id);
                TempData["Message"] = "Job deleted successfully";
            }
            catch (Exception e)
            {
                TempData["Message"] = $"Error deleting job. {e.Message}";
            }
            return RedirectToAction("index");
        }


        [HttpPost]
        public ActionResult Update(JOBS job)
        {
            var logic = new JobsLogic();
            var jobEntity = logic.GetOne(job.ID);
            if (job.JOB_NAME != null)
                jobEntity.JOB_NAME = job.JOB_NAME;
            try
            {
                logic.Update(jobEntity); 
                TempData["Message"] = "Job updated successfully";
            }
            catch (Exception e)
            {
                TempData["Message"] = $"Error updating job. {e.Message}";
            }
            return RedirectToAction("index");
        }

    }
}