using DataAccess;
using Entities;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace Logic
{
    public class ProductsLogic : Logic, ILogic<Products>
    {
        public List<Products> All()
        {
            return context.Products.ToList();
        }

        public Products One(int id)
        {
            return context.Products.FirstOrDefault(c => c.ProductID.Equals(id));

        }

        public void Delete(Products entity)
        {
            Products todelete = One(entity.ProductID);
            context.Products.Remove(todelete);
            context.SaveChanges();
        }

        public void Insert(Products entity)
        {
            context.Products.Add(entity);
            context.SaveChanges();
        }

        public void Update(Products entity)
        {
            Products tomodify = One(entity.ProductID);
            tomodify.ProductName = entity.ProductName;
            tomodify.QuantityPerUnit = entity.QuantityPerUnit;
            tomodify.UnitPrice = entity.UnitPrice;
            tomodify.ReorderLevel = entity.ReorderLevel;
            tomodify.SupplierID = tomodify.SupplierID;
            tomodify.CategoryID = tomodify.CategoryID;
            tomodify.Discontinued = tomodify.Discontinued;
            tomodify.UnitsInStock = tomodify.UnitsInStock;
            tomodify.UnitsOnOrder = tomodify.UnitsOnOrder;
            context.SaveChanges();
        }
    }
}
