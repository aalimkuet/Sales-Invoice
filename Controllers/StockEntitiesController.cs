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
    public class StockEntitiesController : Controller
    {
        private SalseInvoiceContext db = new SalseInvoiceContext();

        // GET: StockEntities
        public ActionResult Index()
        {
            return View(db.StockEntities.ToList());
        }

        // GET: StockEntities/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StockEntity stockEntity = db.StockEntities.Find(id);
            if (stockEntity == null)
            {
                return HttpNotFound();
            }
            return View(stockEntity);
        }

        // GET: StockEntities/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StockEntities/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,totalPrice,productQuantity")] StockEntity stockEntity)
        {
            if (ModelState.IsValid)
            {
                db.StockEntities.Add(stockEntity);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(stockEntity);
        }

        // GET: StockEntities/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StockEntity stockEntity = db.StockEntities.Find(id);
            if (stockEntity == null)
            {
                return HttpNotFound();
            }
            return View(stockEntity);
        }

        // POST: StockEntities/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,totalPrice,productQuantity")] StockEntity stockEntity)
        {
            if (ModelState.IsValid)
            {
                db.Entry(stockEntity).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(stockEntity);
        }

        // GET: StockEntities/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StockEntity stockEntity = db.StockEntities.Find(id);
            if (stockEntity == null)
            {
                return HttpNotFound();
            }
            return View(stockEntity);
        }

        // POST: StockEntities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            StockEntity stockEntity = db.StockEntities.Find(id);
            db.StockEntities.Remove(stockEntity);
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
