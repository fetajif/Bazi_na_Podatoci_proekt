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
    public class KnigaController : Controller
    {
        private OnlineBookstoreContext db = new OnlineBookstoreContext();

        // GET: Kniga
        public ActionResult Index()
        {
            return View(db.Knigi.ToList());
        }

        // GET: Kniga/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            kniga kniga = db.Knigi.Find(id);
            if (kniga == null)
            {
                return HttpNotFound();
            }
            return View(kniga);
        }

        // GET: Kniga/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Kniga/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "isbn,naslov,godinaIzdavanje,kategorija,embg_izdavac")] kniga kniga)
        {
            if (ModelState.IsValid)
            {
                db.Knigi.Add(kniga);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(kniga);
        }

        // GET: Kniga/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            kniga kniga = db.Knigi.Find(id);
            if (kniga == null)
            {
                return HttpNotFound();
            }
            return View(kniga);
        }

        // POST: Kniga/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "isbn,naslov,godinaIzdavanje,kategorija,embg_izdavac")] kniga kniga)
        {
            if (ModelState.IsValid)
            {
                db.Entry(kniga).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(kniga);
        }

        // GET: Kniga/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            kniga kniga = db.Knigi.Find(id);
            if (kniga == null)
            {
                return HttpNotFound();
            }
            return View(kniga);
        }

        // POST: Kniga/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            kniga kniga = db.Knigi.Find(id);
            db.Knigi.Remove(kniga);
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
