using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Logic
{
    public class JobsLogic : Logic, ILogic<JOBS>
    {
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(string id)
        {
            try
            {
                JOBS jobsDelete = GetOne(id);
                context.JOBS.Remove(jobsDelete);
                context.SaveChanges();
            }
            catch
            {
                throw new Exception("Ocurrió un error al eliminar el puesto de trabajo");
            }
        }

        public List<JOBS> GetAll()
        {
            try
            {
                return context.JOBS.ToList();
            }
            catch
            {
                throw new Exception("Ocurrió un error al obtener los puestos de trabajo");
            }
        }

        public JOBS GetOne(string id)
        {
            try
            {
                return context.JOBS.First(r => r.ID.Equals(id));
            }
            catch
            {
                throw new Exception("Ocurrió un error al obtener el puesto de trabajo");
            }
        }

        public JOBS Insert(JOBS entity)
        {
            try
            {
                JOBS newJob = context.JOBS.Add(entity);
                context.SaveChanges();
                return newJob;
            }
            catch
            {
                throw new Exception("Ocurrió un error al insertar el puesto de trabajo");
            }

        }

        public void Update(JOBS entity)
        {
            try
            {
                JOBS jobsUpdate = GetOne(entity.ID);
                jobsUpdate.JOB_NAME = entity.JOB_NAME;
                context.SaveChanges();
            }
            catch
            {
                throw new Exception("Ocurrió un error al actualizar los puestos de trabajo");
            }
        }
    }
}
