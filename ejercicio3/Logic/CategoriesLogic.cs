using DataAccess;
using Entities;
using System.Collections.Generic;
using System.Linq;

namespace Logic
{
    public class CategoriesLogic
    {
        private readonly NorthwindContext context;

        public CategoriesLogic()
        {
            this.context = new NorthwindContext();
        }
        public List<Categories> Categories()
        {
            return context.Categories.ToList();
        }

        public Categories Category(int id)
        {
            return context.Categories.FirstOrDefault(c => c.CategoryID.Equals(id));

        }
    }
}
