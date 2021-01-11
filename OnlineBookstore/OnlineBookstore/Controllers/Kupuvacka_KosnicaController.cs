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
    public class Kupuvacka_KosnicaController : Controller
    {
        private OnlineBookstoreContext db = new OnlineBookstoreContext();

        // GET: Kupuvacka_Kosnica
        public ActionResult Index()
        {
            return View(db.Kupuvacka_Kosnicas.ToList());
        }

        // GET: Kupuvacka_Kosnica/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            kupuvacka_kosnica kupuvacka_kosnica = db.Kupuvacka_Kosnicas.Find(id);
            if (kupuvacka_kosnica == null)
            {
                return HttpNotFound();
            }
            return View(kupuvacka_kosnica);
        }

        // GET: Kupuvacka_Kosnica/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Kupuvacka_Kosnica/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "kosnicka_id,embg_korisnik")] kupuvacka_kosnica kupuvacka_kosnica)
        {
            if (ModelState.IsValid)
            {
                db.Kupuvacka_Kosnicas.Add(kupuvacka_kosnica);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(kupuvacka_kosnica);
        }

        // GET: Kupuvacka_Kosnica/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            kupuvacka_kosnica kupuvacka_kosnica = db.Kupuvacka_Kosnicas.Find(id);
            if (kupuvacka_kosnica == null)
            {
                return HttpNotFound();
            }
            return View(kupuvacka_kosnica);
        }

        // POST: Kupuvacka_Kosnica/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "kosnicka_id,embg_korisnik")] kupuvacka_kosnica kupuvacka_kosnica)
        {
            if (ModelState.IsValid)
            {
                db.Entry(kupuvacka_kosnica).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(kupuvacka_kosnica);
        }

        // GET: Kupuvacka_Kosnica/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            kupuvacka_kosnica kupuvacka_kosnica = db.Kupuvacka_Kosnicas.Find(id);
            if (kupuvacka_kosnica == null)
            {
                return HttpNotFound();
            }
            return View(kupuvacka_kosnica);
        }

        // POST: Kupuvacka_Kosnica/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            kupuvacka_kosnica kupuvacka_kosnica = db.Kupuvacka_Kosnicas.Find(id);
            db.Kupuvacka_Kosnicas.Remove(kupuvacka_kosnica);
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
