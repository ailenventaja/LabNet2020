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
            if (TempData["Message"] != null)
                ViewBag.Message = TempData["Message"].ToString();

            return View(employees);
        }
        public ActionResult Insert()
        {
            return View();
        }

        public ActionResult Update(int id)
        {
            var logic = new EmployeesLogic();
            var employee = logic.GetOne(id);
            return View(employee);
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
            try
            {
                logic.Insert(employeeEntity);
                TempData["Message"] = "New employee added successfully";
            }
            catch (Exception e)
            {
                TempData["Message"] = $"Error adding new employee. {e.Message}";
            }
            
            return RedirectToAction("index");
        }


        public ActionResult Delete(int id)
        {
            var logic = new EmployeesLogic();
            try
            {
                logic.Delete(id);
                TempData["Message"] = "Employee deleted successfully";
            }
            catch (Exception e)
            {
                TempData["Message"] = $"Error deleting employee. {e.Message}";
            }
            return RedirectToAction("index");
        }


        [HttpPost]
        public ActionResult Update(EMPLOYEES employee)
        {
                var logic = new EmployeesLogic();
                var employeeEntity = logic.GetOne(employee.ID);
            if (employee.FIRST_NAME != null)
                employeeEntity.FIRST_NAME = employee.FIRST_NAME;
            if (employee.LAST_NAME != null)
                employeeEntity.LAST_NAME = employee.LAST_NAME;
            if (employee.HIRE_DATE != null)
                employeeEntity.MANAGER_ID = employee.MANAGER_ID;
            if (employee.SALARY != null)
                employeeEntity.SALARY = employee.SALARY;
            if (employee.JOB_ID != null)
                employeeEntity.JOB_ID = employee.JOB_ID;
            if (employee.DEPARTMENT_ID != null)
                employeeEntity.DEPARTMENT_ID = employee.DEPARTMENT_ID;
            try
            {
                logic.Update(employeeEntity);
                TempData["Message"] = "Employee updated successfully";
            }
            catch (Exception e)
            {
                TempData["Message"] = $"Error updating employee. {e.Message}";
            }
            return RedirectToAction("index");
        }
    }
}