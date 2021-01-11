using OnlineBookstore.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineBookstore.Controllers
{
    public class Pogledi_Formi_IzvestaiController : Controller
    {
        private OnlineBookstoreContext db = new OnlineBookstoreContext();

        // GET: Pogledi_Formi_Izvestai
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult KnigaAvtoriPogled()
        {
            return View(db.pogled_Kniga_Avtori.ToList());
        }

        public ActionResult KupeniKnigiPogled()
        {
            return View(db.pogled_Kupeni_Knigi.ToList());
        }

        public ActionResult VkupnoPotrosilKorisnik()
        {
            return View(db.vkupno_Potrosil_Korisnik.ToList());
        }

        public ActionResult NajprodadenaKniga()
        {
            return View(db.NajprodadenaKniga.ToList());
        }

        public ActionResult KorisnikKojPotrosilNajmnogu()
        {
            return View(db.Korisnik_Potrosil_Najmnogu.ToList());
        }

        public ActionResult KupiKniga()
        {
            formaKupiKniga model = new formaKupiKniga();
            model.kosnicka_ids = db.Kupuvacka_Kosnicas.ToList();
            model.primerok_ids = db.Primerok_Kniga.Where(m => m.kosnicka_id == null).ToList();
            return View(model);
        }

        [HttpPost]
        public ActionResult KupiKniga(formaKupiKniga model)
        {
            if (ModelState.IsValid)
            {
                var primerok = db.Primerok_Kniga.Find(model.primerok_id);
                primerok.kosnicka_id = model.kosnicka_id;
                db.Entry(primerok).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public ActionResult SmestiZaliha()
        {
            smestiZaliha model = new smestiZaliha();
            model.magacini = db.Magacins.ToList();
            model.primeroci = db.Primerok_Kniga.ToList();
            return View(model); 
        }

        [HttpPost]
        public ActionResult SmestiZaliha(smestiZaliha model)
        {
            if (ModelState.IsValid)
            {
                var primerok = db.Primerok_Kniga.Find(model.primerok_id);
                primerok.magacin_id = model.magacin_id;
                db.Entry(primerok).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}