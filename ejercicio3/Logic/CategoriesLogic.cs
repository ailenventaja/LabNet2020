using DataAccess;
using Entities;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace Logic
{
    public class CategoriesLogic : Logic, ILogic<Categories>
    {
        public List<Categories> All()
        {
            return context.Categories.ToList();
        }

        public Categories One(int id)
        {
            return context.Categories.FirstOrDefault(c => c.CategoryID.Equals(id));

        }

        public void Delete(Categories entity)
        {
            Categories todelete = One(entity.CategoryID); 
            context.Categories.Remove(todelete);
            context.SaveChanges();
        }

        public void Insert(Categories entity)
        {
            context.Categories.Add(entity);
            context.SaveChanges();
        }

        public void Update(Categories entity)
        {
            Categories tomodify = One(entity.CategoryID);
            tomodify.CategoryName = entity.CategoryName;
            tomodify.Description = entity.Description;
            tomodify.Picture = entity.Picture;
            tomodify.Products = entity.Products;
            context.SaveChanges();
        }
    }
}
