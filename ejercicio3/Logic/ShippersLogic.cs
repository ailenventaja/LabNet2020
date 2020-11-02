using DataAccess;
using Entities;
using System.Collections.Generic;
using System.Linq;

namespace Logic
{
    public class ShippersLogic
    {
        private readonly NorthwindContext context;

        public ShippersLogic()
        {
            this.context = new NorthwindContext();
        }
        public List<Shippers> Shippers()
        {
            return context.Shippers.ToList();
        }

        public Shippers Shipper(int id)
        {
            return context.Shippers.FirstOrDefault(c => c.ShipperID.Equals(id));

        }
    }
}
