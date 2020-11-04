using DataAccess;
using Entities;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace Logic
{
    public class ShippersLogic : Logic, ILogic<Shippers>
    {
        public List<Shippers> All()
        {
            return context.Shippers.ToList();
        }

        public Shippers One(int id)
        {
            return context.Shippers.FirstOrDefault(c => c.ShipperID.Equals(id));

        }

        public void Delete(Shippers entity)
        {
            Shippers todelete = One(entity.ShipperID);
            context.Shippers.Remove(todelete);
            context.SaveChanges();
        }

        public void Insert(Shippers entity)
        {
            context.Shippers.Add(entity);
            context.SaveChanges();
        }

        public void Update(Shippers entity)
        {
            Shippers tomodify = One(entity.ShipperID); 
            tomodify.CompanyName = entity.CompanyName;
            tomodify.Phone = entity.Phone;
            context.SaveChanges();
        }
    }
}
