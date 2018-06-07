using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Aerodrom.Models;

namespace Aerodrom.Controllers
{
    public class MapasController : Controller
    {
        private AerodromContext db = new AerodromContext();

        // GET: Mapas
        public async Task<ActionResult> Index()
        {
            return View();
        }

        

        // GET: Mapas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Mapas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "MapaId")] Mapa mapa)
        {
            if (ModelState.IsValid)
            {
                db.Mapas.Add(mapa);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(mapa);
        }

        // GET: Mapas/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mapa mapa = await db.Mapas.FindAsync(id);
            if (mapa == null)
            {
                return HttpNotFound();
            }
            return View(mapa);
        }

        // POST: Mapas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "MapaId")] Mapa mapa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mapa).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(mapa);
        }

        // GET: Mapas/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mapa mapa = await db.Mapas.FindAsync(id);
            if (mapa == null)
            {
                return HttpNotFound();
            }
            return View(mapa);
        }

        // POST: Mapas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Mapa mapa = await db.Mapas.FindAsync(id);
            db.Mapas.Remove(mapa);
            await db.SaveChangesAsync();
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
