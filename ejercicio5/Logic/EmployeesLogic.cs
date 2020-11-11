using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Logic
{
    public class EmployeesLogic : Logic, ILogic<EMPLOYEES>
    {
        public void Delete(int id)
        {
            try
            {
                EMPLOYEES employeesDelete = GetOne(id);
                context.EMPLOYEES.Remove(employeesDelete);
                context.SaveChanges();
            }
            catch
            {
                throw new Exception("Ocurrió un error al eliminar el empleado");
            }
        }

        public List<EMPLOYEES> GetAll()
        {
            try
            {
                return context.EMPLOYEES.ToList();
            }
            catch
            {
                throw new Exception("Ocurrió un error al obtener los empleados");
            }
        }

        public EMPLOYEES GetOne(int id)
        {
            try
            {
                return context.EMPLOYEES.First(r => r.ID.Equals(id));
            }
            catch
            {
                throw new Exception("Ocurrió un error al obtener el empleado");
            }
        }

        public EMPLOYEES Insert(EMPLOYEES entity)
        {
            try
            {
                int lastID = (from emp in context.EMPLOYEES
                                orderby emp.ID descending
                                select emp.ID).FirstOrDefault();
                lastID += 1;
                entity.ID = lastID;
                EMPLOYEES newEmployee = context.EMPLOYEES.Add(entity);
                context.SaveChanges();
                return newEmployee;
            }
            catch
            {
                throw new Exception("Ocurrió un error al insertar el empleado");
            }
        }

        public void Update(EMPLOYEES entity)
        {
                try
                { 
                EMPLOYEES employeesUpdate = GetOne(entity.ID);
                employeesUpdate.FIRST_NAME = entity.FIRST_NAME;
                employeesUpdate.LAST_NAME = entity.LAST_NAME;
                employeesUpdate.MANAGER_ID = entity.MANAGER_ID;
                employeesUpdate.SALARY = entity.SALARY;
                context.SaveChanges();
            }
            catch
            {
                throw new Exception("Ocurrió un error al actualizar el empleado");
            }

        }
    }
}
