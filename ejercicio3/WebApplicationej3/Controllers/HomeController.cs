using Logic;
using System;
using System.Data.SqlClient;
using System.Web.Mvc;

namespace WebApplicationej3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            #region Insert
            SqlConnection cnn;
            string connectionString;
            connectionString = @"data source=(LocalDB)\MSSQLLocalDB;initial catalog=Northwind;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sqlInsert = "";
            sqlInsert = "Insert into Shippers (CompanyName, Phone) values ('New Company Test', '(503) 555-4027')";
            command = new SqlCommand(sqlInsert, cnn);
            adapter.InsertCommand = new SqlCommand(sqlInsert, cnn);
            command.ExecuteNonQuery();
            #endregion

            #region Update
            String sqlUpdate = "";
            sqlUpdate = "Update Categories set CategoryName='Update Test' where CategoryID=3";
            command = new SqlCommand(sqlUpdate, cnn);
            adapter.InsertCommand = new SqlCommand(sqlUpdate, cnn);
            command.ExecuteNonQuery();
            #endregion


            #region Delete
            //String sqlDelete = "";
            //sqlDelete = "Delete [Order Details] where OrderID=10251";
            //command = new SqlCommand(sqlDelete, cnn);
            //adapter.InsertCommand = new SqlCommand(sqlDelete, cnn);
            //command.ExecuteNonQuery();
            #endregion

            #region Create objects and ViewBags
            CategoriesLogic categoriesLogic = new CategoriesLogic();
            var categories = categoriesLogic.Categories();
            ShippersLogic shippersLogic = new ShippersLogic();
            var shippers = shippersLogic.Shippers();
            ProductsLogic productsLogic = new ProductsLogic();
            var product5 = productsLogic.Product(5);
            var product10 = productsLogic.Product(10);
            var product20 = productsLogic.Product(20);
            var product30 = productsLogic.Product(30);
            ViewBag.Product5 = product5;
            ViewBag.Product10 = product10;
            ViewBag.Product20 = product20;
            ViewBag.Product30 = product30;
            ViewBag.Categories = categories;
            ViewBag.Shippers = shippers;
            return View();
            #endregion
        }

    }
}