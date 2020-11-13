using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.IO;
using log4net;
using log4net.Repository.Hierarchy;
using System.Diagnostics;
using Entities;
using NLog.Fluent;

namespace Logic
{
    public class JobsLogic : Logic, ILogic<JOBS>
    {
        public void Delete(int id)
        {
            
        }

        public void Delete(string id)
        {
            try
            {
                JOBS jobsDelete = GetOne(id);
                context.JOBS.Remove(jobsDelete);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                Log2.save(this, e);
                throw new Exception("If the error persists, please retry again later.");
            }
            
        }

        public List<JOBS> GetAll()
        {
            try
            {
                return context.JOBS.ToList();
            }
            catch (Exception e)
            {
                Log2.save(this, e);
                throw new Exception("If the error persists, please retry again later.");
            }
        }

        public JOBS GetOne(string id)
        {
            try
            {
                return context.JOBS.First(r => r.ID.Equals(id));
            }
            catch (Exception e)
            {
                Log2.save(this, e);
                throw new Exception("If the error persists, please retry again later.");
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
            catch (Exception e)
            {
                Log2.save(this, e);
                throw new Exception("Remember to enter a new ID (character limit: 6). If the error persists, please retry again later.");
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
            catch (Exception e)
            {
                Log2.save(this, e);
                throw new Exception("If the error persists, please retry again later.");
            }
        }
    }
}
