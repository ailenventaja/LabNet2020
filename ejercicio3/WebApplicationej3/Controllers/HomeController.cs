using Logic;
using System;
using System.Data.SqlClient;
using System.Web.Mvc;
using Entities;
using DataAccess;
using System.Linq;

namespace WebApplicationej3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string sortOrder)
        {
            //Probé los insert, update y delete con SqlConnection, 
            //pasé todo a Logic pero terminé haciéndolos en sus respectivos controllers, dejo esto acá que fue lo primero

            #region Crud Methods
            Crud crud = new Crud();
            string sqlInsert = "Insert into Shippers (CompanyName, Phone) values ('New Company Crud Test', '(503) 555-4027')";
            crud.Insert(sqlInsert);
            string sqlUpdate = "Update Categories set CategoryName='Update Crud' where CategoryID=3";
            crud.Update(sqlUpdate);
            //string sqlDelete = "Delete [Order Details] where OrderID=10251";
            //crud.Delete(sqlDelete);
            #endregion

            #region Insert Method
            ShippersLogic shippersLogic = new ShippersLogic();
            shippersLogic.Insert(new Entities.Shippers
            {
                CompanyName = "Insert test",
                Phone = "(555) 54321355"
            });

            #endregion

            #region Order
            NorthwindContext northwindContext = new NorthwindContext();
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.IDSortParm = sortOrder == "ShipperID" ? "ID_desc" : "ID";
            var shippers = from s in northwindContext.Shippers
                           select s;
            switch (sortOrder)
            {
                case "name_desc":
                    shippers = shippers.OrderByDescending(s => s.CompanyName);
                    break;
                case "ID":
                    shippers = shippers.OrderBy(s => s.ShipperID);
                    break;
                default:
                    shippers = shippers.OrderBy(s => s.CompanyName);
                    break;
            }
            #endregion

            #region Create objects and ViewBags
            CategoriesLogic categoriesLogic = new CategoriesLogic();
            var categories = categoriesLogic.All();
            var shipper = shippersLogic.All();
            ProductsLogic productsLogic = new ProductsLogic();
            var product5 = productsLogic.One(5);
            var product10 = productsLogic.One(10);
            var product20 = productsLogic.One(20);
            var product30 = productsLogic.One(30);
            ViewBag.Product5 = product5;
            ViewBag.Product10 = product10;
            ViewBag.Product20 = product20;
            ViewBag.Product30 = product30;
            ViewBag.Categories = categories;
            ViewBag.Shippers = shipper;
            return View(shippers.ToList());
            #endregion
        }

        [HttpPost]
        public ActionResult Search(string idp)
        {
            ProductsLogic product = new ProductsLogic();
            Products result = product.One(int.Parse(idp));
            ViewBag.Result = result;
            return View();

        }
    }
}