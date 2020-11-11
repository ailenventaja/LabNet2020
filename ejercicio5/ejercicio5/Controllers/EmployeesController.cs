using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entities;
using Logic;

namespace ejercicio5.Controllers
{
    public class EmployeesController : Controller
    {
        // GET: Employees
        public ActionResult Index()
        {
            var logic = new EmployeesLogic();
            var employees = logic.GetAll();
            return View(employees);
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
        public ActionResult Insert(EMPLOYEES employee)
        {
            var logic = new EmployeesLogic();
            var employeeEntity = new EMPLOYEES();
            employeeEntity.FIRST_NAME = employee.FIRST_NAME;
            employeeEntity.LAST_NAME = employee.LAST_NAME;
            employeeEntity.HIRE_DATE = employee.HIRE_DATE;
            employeeEntity.JOB_ID = employee.JOB_ID;
            employeeEntity.DEPARTMENT_ID = employee.DEPARTMENT_ID;
            employeeEntity.MANAGER_ID = employee.MANAGER_ID;
            employeeEntity.SALARY = employee.SALARY;
            logic.Insert(employeeEntity);
            return RedirectToAction("index");
        }


        public ActionResult Delete(int id)
        {
            var logic = new EmployeesLogic();
            logic.Delete(id);
            return RedirectToAction("index");
        }


        [HttpPost]
        public ActionResult Update(int id, EMPLOYEES employee)
        {
                var logic = new EmployeesLogic();
                var employeeEntity = logic.GetOne(id);
            if (employee.FIRST_NAME != null)
                employeeEntity.FIRST_NAME = employee.FIRST_NAME;
            if (employee.LAST_NAME != null)
                employeeEntity.LAST_NAME = employee.LAST_NAME;
            if (employee.HIRE_DATE != null)
                employeeEntity.MANAGER_ID = employee.MANAGER_ID;
            if (employee.SALARY != null)
                employeeEntity.SALARY = employee.SALARY;
            logic.Update(employeeEntity);
            return RedirectToAction("index");
        }
    }
}