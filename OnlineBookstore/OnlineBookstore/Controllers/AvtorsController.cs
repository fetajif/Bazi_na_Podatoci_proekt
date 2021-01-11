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
    public class AvtorsController : Controller
    {
        private OnlineBookstoreContext db = new OnlineBookstoreContext();

        // GET: Avtors
        public ActionResult Index()
        {
            return View(db.avtor.ToList());
        }

        //GET: Avtors: All Details about Avtors
        public ActionResult IndexDetailed()
        {
            string query = "select embg, ime, prezime, adresa" +
                            " from online_bookstore.covek c " +
                            " join online_bookstore.avtor a on c.embg = a.embg_avtor;";
            var result = db.Database.SqlQuery<covek>(query);
            return View(result);
        }

        // GET: Avtors/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            avtor avtor = db.avtor.Find(id);
            if (avtor == null)
            {
                return HttpNotFound();
            }
            return View(avtor);
        }

        // GET: Avtors/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Avtors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "embg_avtor,url")] avtor avtor)
        {
            if (ModelState.IsValid)
            {
                db.avtor.Add(avtor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(avtor);
        }

        // GET: Avtors/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            avtor avtor = db.avtor.Find(id);
            if (avtor == null)
            {
                return HttpNotFound();
            }
            return View(avtor);
        }

        // POST: Avtors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "embg_avtor,url")] avtor avtor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(avtor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(avtor);
        }

        // GET: Avtors/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            avtor avtor = db.avtor.Find(id);
            if (avtor == null)
            {
                return HttpNotFound();
            }
            return View(avtor);
        }

        // POST: Avtors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            avtor avtor = db.avtor.Find(id);
            db.avtor.Remove(avtor);
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
