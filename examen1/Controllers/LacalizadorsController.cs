using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using examen1.Models;

namespace examen1.Controllers
{
    public class LacalizadorsController : Controller
    {
        private examen1Context db = new examen1Context();

        // GET: Lacalizadors
        public ActionResult Index()
        {
            return View(db.Lacalizadors.ToList());
        }

        // GET: Lacalizadors/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lacalizador lacalizador = db.Lacalizadors.Find(id);
            if (lacalizador == null)
            {
                return HttpNotFound();
            }
            return View(lacalizador);
        }

        // GET: Lacalizadors/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Lacalizadors/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Phone,Car,Color,Direccion,Price")] Lacalizador lacalizador)
        {
            if (ModelState.IsValid)
            {
                db.Lacalizadors.Add(lacalizador);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(lacalizador);
        }

        // GET: Lacalizadors/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lacalizador lacalizador = db.Lacalizadors.Find(id);
            if (lacalizador == null)
            {
                return HttpNotFound();
            }
            return View(lacalizador);
        }

        // POST: Lacalizadors/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Phone,Car,Color,Direccion,Price")] Lacalizador lacalizador)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lacalizador).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(lacalizador);
        }

        // GET: Lacalizadors/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lacalizador lacalizador = db.Lacalizadors.Find(id);
            if (lacalizador == null)
            {
                return HttpNotFound();
            }
            return View(lacalizador);
        }

        // POST: Lacalizadors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Lacalizador lacalizador = db.Lacalizadors.Find(id);
            db.Lacalizadors.Remove(lacalizador);
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
