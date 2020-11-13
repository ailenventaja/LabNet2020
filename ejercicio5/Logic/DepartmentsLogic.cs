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
            catch (Exception e)
            {
                Log2.save(this, e);
                throw new Exception("If the error persists, please try again later.");
            }
        }

        public List<DEPARTMENTS> GetAll()
        {
            try
            {
                return context.DEPARTMENTS.ToList();
            }
            catch (Exception e)
            {
                Log2.save(this, e);
                throw new Exception("If the error persists, please try again later.");
            }
        }

        public DEPARTMENTS GetOne(int id)
        {
            try
            {
                return context.DEPARTMENTS.First(r => r.ID.Equals(id));
            }
            catch (Exception e)
            {
                Log2.save(this, e);
                throw new Exception("If the error persists, please try again later.");
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
            catch (Exception e)
            {
                Log2.save(this, e);
                throw new Exception("Remember to enter a new ID. If the error persists, please try again later.");
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
            catch (Exception e)
            {
                Log2.save(this, e);
                throw new Exception("If the error persists, please try again later.");
            }
        }
    }
}
