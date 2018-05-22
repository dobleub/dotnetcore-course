using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MiCodeFirst_DataAnnotations.Models;

namespace MiCodeFirst_DataAnnotations.Controllers
{
    public class LicenciaConducirsController : Controller
    {
        private LicenciaConducirContext db = new LicenciaConducirContext();

        // GET: LicenciaConducirs
        public ActionResult Index()
        {
            return View(db.LicenciaConducirs.ToList());
        }

        // GET: LicenciaConducirs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LicenciaConducir licenciaConducir = db.LicenciaConducirs.Find(id);
            if (licenciaConducir == null)
            {
                return HttpNotFound();
            }
            return View(licenciaConducir);
        }

        // GET: LicenciaConducirs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LicenciaConducirs/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NumeroLicencia,Pais,Expedido,Caduca")] LicenciaConducir licenciaConducir)
        {
            if (ModelState.IsValid)
            {
                db.LicenciaConducirs.Add(licenciaConducir);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(licenciaConducir);
        }

        // GET: LicenciaConducirs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LicenciaConducir licenciaConducir = db.LicenciaConducirs.Find(id);
            if (licenciaConducir == null)
            {
                return HttpNotFound();
            }
            return View(licenciaConducir);
        }

        // POST: LicenciaConducirs/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NumeroLicencia,Pais,Expedido,Caduca")] LicenciaConducir licenciaConducir)
        {
            if (ModelState.IsValid)
            {
                db.Entry(licenciaConducir).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(licenciaConducir);
        }

        // GET: LicenciaConducirs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LicenciaConducir licenciaConducir = db.LicenciaConducirs.Find(id);
            if (licenciaConducir == null)
            {
                return HttpNotFound();
            }
            return View(licenciaConducir);
        }

        // POST: LicenciaConducirs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LicenciaConducir licenciaConducir = db.LicenciaConducirs.Find(id);
            db.LicenciaConducirs.Remove(licenciaConducir);
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
