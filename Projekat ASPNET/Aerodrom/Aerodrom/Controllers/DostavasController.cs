using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Aerodrom.Models;

namespace Aerodrom.Controllers
{   
    public class DostavasController : Controller
    {
        private AerodromContext db = new AerodromContext();

        // GET: Dostavas
        public ActionResult Index()
        {
            return View(db.Dostava.ToList());
        }

        // GET: Dostavas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dostava dostava = db.Dostava.Find(id);
            if (dostava == null)
            {
                return HttpNotFound();
            }
            return View(dostava);
        }

        // GET: Dostavas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Dostavas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DostavaId,Kupac")] Dostava dostava)
        {
            if (ModelState.IsValid)
            {
                db.Dostava.Add(dostava);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dostava);
        }

        // GET: Dostavas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dostava dostava = db.Dostava.Find(id);
            if (dostava == null)
            {
                return HttpNotFound();
            }
            return View(dostava);
        }

        // POST: Dostavas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DostavaId,Kupac")] Dostava dostava)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dostava).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dostava);
        }

        // GET: Dostavas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dostava dostava = db.Dostava.Find(id);
            if (dostava == null)
            {
                return HttpNotFound();
            }
            return View(dostava);
        }

        // POST: Dostavas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Dostava dostava = db.Dostava.Find(id);
            db.Dostava.Remove(dostava);
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
