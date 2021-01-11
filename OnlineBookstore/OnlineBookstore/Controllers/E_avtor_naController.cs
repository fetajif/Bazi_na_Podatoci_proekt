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
    public class E_avtor_naController : Controller
    {
        private OnlineBookstoreContext db = new OnlineBookstoreContext();

        // GET: E_avtor_na
        public ActionResult Index()
        {
            string query = "select naslov, c.ime || ' ' || c.prezime as avtor " +
                 " from online_bookstore.e_avtor_na ean " +
                 " join online_bookstore.kniga k on ean.isbn = k.isbn " +
                 " join online_bookstore.covek c on ean.embg_avtor = c.embg;";
            var result = db.Database.SqlQuery<KnigaAvtor>(query);
            return View(result);
        }

        // GET: E_avtor_na/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            e_avtor_na e_avtor_na = db.E_Avtor_Na.Find(id);
            if (e_avtor_na == null)
            {
                return HttpNotFound();
            }
            return View(e_avtor_na);
        }

        // GET: E_avtor_na/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: E_avtor_na/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "isbn,embg_avtor")] e_avtor_na e_avtor_na)
        {
            if (ModelState.IsValid)
            {
                db.E_Avtor_Na.Add(e_avtor_na);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(e_avtor_na);
        }

        // GET: E_avtor_na/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            e_avtor_na e_avtor_na = db.E_Avtor_Na.Find(id);
            if (e_avtor_na == null)
            {
                return HttpNotFound();
            }
            return View(e_avtor_na);
        }

        // POST: E_avtor_na/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "isbn,embg_avtor")] e_avtor_na e_avtor_na)
        {
            if (ModelState.IsValid)
            {
                db.Entry(e_avtor_na).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(e_avtor_na);
        }

        // GET: E_avtor_na/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            e_avtor_na e_avtor_na = db.E_Avtor_Na.Find(id);
            if (e_avtor_na == null)
            {
                return HttpNotFound();
            }
            return View(e_avtor_na);
        }

        // POST: E_avtor_na/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            e_avtor_na e_avtor_na = db.E_Avtor_Na.Find(id);
            db.E_Avtor_Na.Remove(e_avtor_na);
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
