using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using Entities;


namespace Logic
{
    public class LocationsLogic : Logic, ILogic<LOCATIONS>
    {
    
        public void Delete(int id)
        {
            try
            {
                LOCATIONS locationsDelete = GetOne(id);
                context.LOCATIONS.Remove(locationsDelete);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                Log2.save(this, e);
                throw new Exception("If the error persists, please retry again later.");
            }


        }

        public List<LOCATIONS> GetAll()
        {
            try
            {
                return context.LOCATIONS.ToList();
            }
            catch (Exception e)
            {
                Log2.save(this, e);
                throw new Exception("If the error persists, please retry again later.");
            }

        }

        public LOCATIONS GetOne(int id)
        {
            try
            {
                return context.LOCATIONS.First(r => r.ID.Equals(id));
            }
            catch (Exception e)
            {
                Log2.save(this, e);
                throw new Exception("If the error persists, please retry again later.");
            }

        }

        public LOCATIONS Insert(LOCATIONS entity)
        {
            try
            {
                int lastID = (from loc in context.LOCATIONS
                                orderby loc.ID descending
                                select loc.ID).FirstOrDefault();
                lastID += 1;
                entity.ID = lastID;
                LOCATIONS newLocation = context.LOCATIONS.Add(entity);
                context.SaveChanges();
                return newLocation;
            }
            catch (Exception e)
            {
                Log2.save(this, e);
                throw new Exception("If the error persists, please retry again later.");
            }

        }

        public void Update(LOCATIONS entity)
        {
            try
            {
                LOCATIONS locationUpdate = GetOne(entity.ID);
                locationUpdate.CITY = entity.CITY;
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
