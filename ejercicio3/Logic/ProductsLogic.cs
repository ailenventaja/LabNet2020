using DataAccess;
using Entities;
using System.Collections.Generic;
using System.Linq;

namespace Logic
{
    public class ProductsLogic
    {
        private readonly NorthwindContext context;

        public ProductsLogic()
        {
            this.context = new NorthwindContext();
        }
        public List<Products> Products()
        {
            return context.Products.ToList();
        }

        public Products Product(int id)
        {
            return context.Products.FirstOrDefault(c => c.ProductID.Equals(id));

        }
    }
}
