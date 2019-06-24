using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SalseInVoice00.Models;
using SalseInvoice.Models;

namespace SalseInvoice.Controllers
{
    public class ProductEntitiesController : Controller
    {
        private SalseInvoiceContext db = new SalseInvoiceContext();

        // GET: ProductEntities
        public ActionResult Index()
        {
            return View(db.ProductEntities.ToList());
        }

        // GET: ProductEntities/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductEntity productEntity = db.ProductEntities.Find(id);
            if (productEntity == null)
            {
                return HttpNotFound();
            }
            return View(productEntity);
        }

        // GET: ProductEntities/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductEntities/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,ProductName,productPrice")] ProductEntity productEntity)
        {
            if (ModelState.IsValid)
            {
                db.ProductEntities.Add(productEntity);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(productEntity);
        }

        // GET: ProductEntities/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductEntity productEntity = db.ProductEntities.Find(id);
            if (productEntity == null)
            {
                return HttpNotFound();
            }
            return View(productEntity);
        }

        // POST: ProductEntities/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,ProductName,productPrice")] ProductEntity productEntity)
        {
            if (ModelState.IsValid)
            {
                db.Entry(productEntity).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(productEntity);
        }

        // GET: ProductEntities/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductEntity productEntity = db.ProductEntities.Find(id);
            if (productEntity == null)
            {
                return HttpNotFound();
            }
            return View(productEntity);
        }

        // POST: ProductEntities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ProductEntity productEntity = db.ProductEntities.Find(id);
            db.ProductEntities.Remove(productEntity);
            db.SaveChanges();
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
