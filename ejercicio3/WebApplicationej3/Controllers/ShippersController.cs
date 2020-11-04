using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DataAccess;
using Entities;

namespace WebApplicationej3.Controllers
{
    public class ShippersController : Controller
    {
        private NorthwindContext db = new NorthwindContext();

        // GET: Shippers
        public ActionResult Index(string search)
        {
            var shippers = from s in db.Shippers
                           select s;
            if (!String.IsNullOrEmpty(search))
            {
                shippers = shippers.Where(s => s.CompanyName.Contains(search));
            }
            return View(shippers.ToList());
        }

        // GET: Shippers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Shippers/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CompanyName,Phone")] Shippers shippers)
        {
           
            if (ModelState.IsValid)
            {
                db.Shippers.Add(shippers);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(shippers);
        }

        // GET: Shippers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Shippers shippers = db.Shippers.Find(id);
            if (shippers == null)
            {
                return HttpNotFound();
            }
            return View(shippers);
        }

        // POST: Shippers/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ShipperID,CompanyName,Phone")] Shippers shippers)
        {
            if (ModelState.IsValid)
            {
                db.Entry(shippers).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(shippers);
        }

        // GET: Shippers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Shippers shippers = db.Shippers.Find(id);
            if (shippers == null)
            {
                return HttpNotFound();
            }
            return View(shippers);
        }

        // POST: Shippers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                Shippers shippers = db.Shippers.Find(id);
                db.Shippers.Remove(shippers);
                db.SaveChanges();
            }
            catch 
            {
                return RedirectToAction("Delete", new { id = id, saveChangesError = true });
            }
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
