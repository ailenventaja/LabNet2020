using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Logic
{
    public class DepartmentsLogic : Logic, ILogic<DEPARTMENTS>
    {
        public void Delete(int id)
        {
            try
            {
                DEPARTMENTS departmentDelete = GetOne(id);
                context.DEPARTMENTS.Remove(departmentDelete);
                context.SaveChanges();
            }
            catch
            {
                throw new Exception("Ocurrió un error al eliminar el empleado");
            }
        }

        public List<DEPARTMENTS> GetAll()
        {
            try
            {
                return context.DEPARTMENTS.ToList();
            }
            catch
            {
                throw new Exception("Ocurrió un error al obtener los departamentos");
            }
        }

        public DEPARTMENTS GetOne(int id)
        {
            try
            {
                return context.DEPARTMENTS.First(r => r.ID.Equals(id));
            }
            catch
            {
                throw new Exception("Ocurrió un error al obtener el departamento");
            }
        }
        public DEPARTMENTS Insert(DEPARTMENTS entity)
        {
            try
            {
                DEPARTMENTS newDepartment = context.DEPARTMENTS.Add(entity);
                context.SaveChanges();
                return newDepartment;
            }
            catch
            {
                throw new Exception("Ocurrió un error al insertar el departamento");
            }
        }

        public void Update(DEPARTMENTS entity)
        {
            try
            {
                DEPARTMENTS departmentsUpdate = GetOne(entity.ID);
                departmentsUpdate.DEPARTMENT_NAME = entity.DEPARTMENT_NAME;
                departmentsUpdate.LOCATION_ID = entity.LOCATION_ID;
                departmentsUpdate.DEPARTMENT_DESCRIPTION = entity.DEPARTMENT_DESCRIPTION;
                context.SaveChanges();
            }
            catch
            {
                throw new Exception("Ocurrió un error al actualizar el departamento");
            }
        }
    }
}
