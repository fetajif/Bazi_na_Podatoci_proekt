using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OnlineBookstore.Models;

namespace OnlineBookstore.Controllers
{
    public class MagacinsController : Controller
    {
        private OnlineBookstoreContext db = new OnlineBookstoreContext();

        // GET: Magacins
        public ActionResult Index()
        {
            return View(db.Magacins.ToList());
        }

        // GET: Magacins/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            magacin magacin = db.Magacins.Find(id);
            if (magacin == null)
            {
                return HttpNotFound();
            }
            return View(magacin);
        }

        // GET: Magacins/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Magacins/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "magacin_id,adresa")] magacin magacin)
        {
            if (ModelState.IsValid)
            {
                db.Magacins.Add(magacin);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(magacin);
        }

        // GET: Magacins/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            magacin magacin = db.Magacins.Find(id);
            if (magacin == null)
            {
                return HttpNotFound();
            }
            return View(magacin);
        }

        // POST: Magacins/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "magacin_id,adresa")] magacin magacin)
        {
            if (ModelState.IsValid)
            {
                db.Entry(magacin).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(magacin);
        }

        // GET: Magacins/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            magacin magacin = db.Magacins.Find(id);
            if (magacin == null)
            {
                return HttpNotFound();
            }
            return View(magacin);
        }

        // POST: Magacins/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            magacin magacin = db.Magacins.Find(id);
            db.Magacins.Remove(magacin);
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
