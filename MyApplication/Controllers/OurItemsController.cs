using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MyApplication.Models;

namespace MyApplication.Controllers
{
    public class OurItemsController : Controller
    {
        private ResturantEntities db = new ResturantEntities();

        // GET: OurItems
        public ActionResult Index()
        {
            return View(db.OurItems.ToList());
        }

        // GET: OurItems/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OurItem ourItem = db.OurItems.Find(id);
            if (ourItem == null)
            {
                return HttpNotFound();
            }
            return View(ourItem);
        }

        // GET: OurItems/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OurItems/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ItemId,Name,CategoryId,TypeId,Price,HalfPrice,CreatedDate,ModifiedDate,Active")] OurItem ourItem)
        {
            if (ModelState.IsValid)
            {
                db.OurItems.Add(ourItem);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ourItem);
        }

        // GET: OurItems/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OurItem ourItem = db.OurItems.Find(id);
            if (ourItem == null)
            {
                return HttpNotFound();
            }
            return View(ourItem);
        }

        // POST: OurItems/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ItemId,Name,CategoryId,TypeId,Price,HalfPrice,CreatedDate,ModifiedDate,Active")] OurItem ourItem)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ourItem).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ourItem);
        }

        // GET: OurItems/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OurItem ourItem = db.OurItems.Find(id);
            if (ourItem == null)
            {
                return HttpNotFound();
            }
            return View(ourItem);
        }

        // POST: OurItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            OurItem ourItem = db.OurItems.Find(id);
            db.OurItems.Remove(ourItem);
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
