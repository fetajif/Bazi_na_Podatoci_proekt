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
    public class CoveksController : Controller
    {
        private OnlineBookstoreContext db = new OnlineBookstoreContext();

        // GET: Coveks
        public ActionResult Index()
        {
            return View(db.covek.ToList());
        }

        // GET: Coveks/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            covek covek = db.covek.Find(id);
            if (covek == null)
            {
                return HttpNotFound();
            }
            return View(covek);
        }

        // GET: Coveks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Coveks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "embg,ime,prezime,adresa")] covek covek)
        {
            if (ModelState.IsValid)
            {
                db.covek.Add(covek);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(covek);
        }

        // GET: Coveks/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            covek covek = db.covek.Find(id);
            if (covek == null)
            {
                return HttpNotFound();
            }
            return View(covek);
        }

        // POST: Coveks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "embg,ime,prezime,adresa")] covek covek)
        {
            if (ModelState.IsValid)
            {
                db.Entry(covek).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(covek);
        }

        // GET: Coveks/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            covek covek = db.covek.Find(id);
            if (covek == null)
            {
                return HttpNotFound();
            }
            return View(covek);
        }

        // POST: Coveks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            covek covek = db.covek.Find(id);
            db.covek.Remove(covek);
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
