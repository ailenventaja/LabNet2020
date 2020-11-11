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
            return View(departments);
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
        public ActionResult Insert(DEPARTMENTS department)
        {
            var logic = new DepartmentsLogic();
            var departmentEntity = new DEPARTMENTS();
            departmentEntity.ID = department.ID;
            departmentEntity.DEPARTMENT_NAME = department.DEPARTMENT_NAME;
            departmentEntity.DEPARTMENT_DESCRIPTION = department.DEPARTMENT_DESCRIPTION;
            departmentEntity.LOCATION_ID = department.LOCATION_ID; 
            logic.Insert(departmentEntity);
            return RedirectToAction("index");
        }

        public ActionResult Delete(int id)
        {
            var logic = new DepartmentsLogic();
            logic.Delete(id);
            return RedirectToAction("index");
        }


        [HttpPost]
        public ActionResult Update(int id, DEPARTMENTS department)
        {
            var logic = new DepartmentsLogic();
            var departmentEntity = logic.GetOne(id);
            if (department.DEPARTMENT_NAME != null)
                departmentEntity.DEPARTMENT_NAME = department.DEPARTMENT_NAME;
            if (department.DEPARTMENT_DESCRIPTION != null)
                departmentEntity.DEPARTMENT_DESCRIPTION = department.DEPARTMENT_DESCRIPTION;
            logic.Update(departmentEntity);
            return RedirectToAction("index");
        }
    }
}