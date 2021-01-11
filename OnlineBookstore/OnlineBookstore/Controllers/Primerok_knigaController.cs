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
    public class Primerok_knigaController : Controller
    {
        private OnlineBookstoreContext db = new OnlineBookstoreContext();

        // GET: Primerok_kniga
        public ActionResult Index()
        {
            return View(db.Primerok_Kniga.ToList());
        }

        // GET: Primerok_kniga/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            primerok_kniga primerok_kniga = db.Primerok_Kniga.Find(id);
            if (primerok_kniga == null)
            {
                return HttpNotFound();
            }
            return View(primerok_kniga);
        }

        // GET: Primerok_kniga/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Primerok_kniga/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "primerok_id,isbn,cena,kosnicka_id,magacin_id")] primerok_kniga primerok_kniga)
        {
            if (ModelState.IsValid)
            {
                db.Primerok_Kniga.Add(primerok_kniga);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(primerok_kniga);
        }

        // GET: Primerok_kniga/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            primerok_kniga primerok_kniga = db.Primerok_Kniga.Find(id);
            if (primerok_kniga == null)
            {
                return HttpNotFound();
            }
            return View(primerok_kniga);
        }

        // POST: Primerok_kniga/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "primerok_id,isbn,cena,kosnicka_id,magacin_id")] primerok_kniga primerok_kniga)
        {
            if (ModelState.IsValid)
            {
                db.Entry(primerok_kniga).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(primerok_kniga);
        }

        // GET: Primerok_kniga/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            primerok_kniga primerok_kniga = db.Primerok_Kniga.Find(id);
            if (primerok_kniga == null)
            {
                return HttpNotFound();
            }
            return View(primerok_kniga);
        }

        // POST: Primerok_kniga/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            primerok_kniga primerok_kniga = db.Primerok_Kniga.Find(id);
            db.Primerok_Kniga.Remove(primerok_kniga);
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
