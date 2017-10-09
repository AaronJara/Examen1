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
    public class AccesoriosController : Controller
    {
        private examen1Context db = new examen1Context();

        // GET: Accesorios
        public ActionResult Index()
        {
            return View(db.Accesorios.ToList());
        }

        // GET: Accesorios/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accesorios accesorios = db.Accesorios.Find(id);
            if (accesorios == null)
            {
                return HttpNotFound();
            }
            return View(accesorios);
        }

        // GET: Accesorios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Accesorios/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,NameAccessorie,Color,Price")] Accesorios accesorios)
        {
            if (ModelState.IsValid)
            {
                db.Accesorios.Add(accesorios);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(accesorios);
        }

        // GET: Accesorios/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accesorios accesorios = db.Accesorios.Find(id);
            if (accesorios == null)
            {
                return HttpNotFound();
            }
            return View(accesorios);
        }

        // POST: Accesorios/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,NameAccessorie,Color,Price")] Accesorios accesorios)
        {
            if (ModelState.IsValid)
            {
                db.Entry(accesorios).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(accesorios);
        }

        // GET: Accesorios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accesorios accesorios = db.Accesorios.Find(id);
            if (accesorios == null)
            {
                return HttpNotFound();
            }
            return View(accesorios);
        }

        // POST: Accesorios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Accesorios accesorios = db.Accesorios.Find(id);
            db.Accesorios.Remove(accesorios);
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
