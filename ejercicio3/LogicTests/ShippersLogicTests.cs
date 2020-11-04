using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.Runtime.Remoting.Contexts;
using DataAccess;

namespace Logic.Tests
{
    [TestClass()]
    public class ShippersLogicTests
    {
        [TestMethod()]
        public void DeleteTest(Shippers entity)
        {
            NorthwindContext context = new NorthwindContext();
            Shippers todelete = context.Shippers.FirstOrDefault(c => c.ShipperID.Equals(id));

            context.Shippers.Remove(todelete);
            context.SaveChanges();
        }
    }



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
}