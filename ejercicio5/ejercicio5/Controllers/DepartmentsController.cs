using System;
using Entities;
using Logic;
using DataAccess;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ejercicio5.Controllers
{
    public class DepartmentsController : Controller
    {
        // GET: Departments
        public ActionResult Index()
        {
            var logic = new DepartmentsLogic();
            var departments = logic.GetAll();
            if (TempData["Message"] != null)
                ViewBag.Message = TempData["Message"].ToString();
            return View(departments);
        }
        public ActionResult Insert()
        {
            return View();
        }

        public ActionResult Update(int id)
        {
            var logic = new DepartmentsLogic();
            var department = logic.GetOne(id);
            return View(department);
        }


        [HttpPost]
        public ActionResult Insert(DEPARTMENTS department)
        {
            var logic = new DepartmentsLogic();
            var departmentEntity = new DEPARTMENTS();
            departmentEntity.ID = department.ID;
            departmentEntity.DEPARTMENT_NAME = department.DEPARTMENT_NAME;
            departmentEntity.DEPARTMENT_DESCRIPTION = department.DEPARTMENT_DESCRIPTION;
            departmentEntity.LOCATION_ID = department.LOCATION_ID; 
            try
            {
                logic.Insert(departmentEntity);
                TempData["Message"] = "New department added successfully";
            }
            catch
            {
                TempData["Message"] = "Error adding new department";
            }
            return RedirectToAction("index");
        }

        public ActionResult Delete(int id)
        {
            var logic = new DepartmentsLogic();
            try
            {
                logic.Delete(id);
                TempData["Message"] = "Department deleted successfully";
            }
            catch (Exception e)
            {
                TempData["Message"] = $"Error deleting department. {e.Message}";
            }
            return RedirectToAction("index");
        }


        [HttpPost]
        public ActionResult Update(DEPARTMENTS department)
        {
            var logic = new DepartmentsLogic();
            var departmentEntity = logic.GetOne(department.ID);
            if (department.DEPARTMENT_NAME != null)
                departmentEntity.DEPARTMENT_NAME = department.DEPARTMENT_NAME;
            if (department.DEPARTMENT_DESCRIPTION != null)
                departmentEntity.DEPARTMENT_DESCRIPTION = department.DEPARTMENT_DESCRIPTION;
            try
            {
                logic.Update(departmentEntity);
                TempData["Message"] = "Department updated successfully";
            }
            catch (Exception e)
            {
                TempData["Message"] = $"Error updating department. {e.Message}";
            }
            return RedirectToAction("index");
        }
    }
}