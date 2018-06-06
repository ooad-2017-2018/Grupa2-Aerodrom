﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using Aerodrom.Models;

namespace Aerodrom.Controllers
{
    public class KartasController : Controller
    {
        private AerodromContext db = new AerodromContext();

        // GET: Kartas
        public ActionResult Index()
        {
            return View(db.Karta.ToList());
        }

        // GET: Kartas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Karta karta = db.Karta.Find(id);
            if (karta == null)
            {
                return HttpNotFound();
            }
            return View(karta);
        }

        // GET: Kartas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Kartas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "KartaId,TipKarte,DatumPolaska,DatumPovratka,Destinacija,Klasa,Sjediste,BrojLeta,AdresaKupca,Kupac")] Karta karta)
        {
            if (ModelState.IsValid)
            {
                //Upis u dostavu
                var cn = new SqlConnection("Server=tcp:aerodromserver.database.windows.net,1433;Initial Catalog=aerodrombaza;Persist Security Info=False;User ID=Admin1;Password=Adminpass1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
                string _sql = @"SELECT adresaStanovanja FROM [dbo].[KorisnikTabela] " +
                              @"WHERE korisnickoIme = @u";

                var cmd = new SqlCommand(_sql, cn);
                cmd.Parameters.Add(new SqlParameter("@u", SqlDbType.NVarChar)).Value = karta.Kupac;
                cn.Open();
                var reader = cmd.ExecuteReader();
                reader.Read();
                db.Karta.Add(karta);
                string _sql2 = @"SELECT max(KartaId) FROM [dbo].[Karta] ";
                var cmd2 = new SqlCommand(_sql2, cn);
                
                
                String adresaKupca = reader.GetString(reader.GetOrdinal("adresaStanovanja"));
                reader.Close();
                var reader2 = cmd2.ExecuteReader();
                reader2.Read();
                int id = reader2.GetInt32(0);
                String ukupneInfo = "ADRESA KUPCA: " + adresaKupca + " ID KARTE:" + id;
                Dostava d = new Dostava();
                d.Kupac = ukupneInfo;
                db.Dostava.Add(d);
                db.SaveChanges();
                return RedirectToAction("Index");
                
                    
            }

            return View(karta);
        }

        // GET: Kartas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Karta karta = db.Karta.Find(id);
            if (karta == null)
            {
                return HttpNotFound();
            }
            return View(karta);
        }

        // POST: Kartas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "KartaId,TipKarte,DatumPolaska,DatumPovratka,Destinacija,Klasa,Sjediste,BrojLeta,AdresaKupca,Kupac")] Karta karta)
        {
            if (ModelState.IsValid)
            {
                db.Entry(karta).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(karta);
        }

        // GET: Kartas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Karta karta = db.Karta.Find(id);
            if (karta == null)
            {
                return HttpNotFound();
            }
            return View(karta);
        }

        // POST: Kartas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Karta karta = db.Karta.Find(id);
            db.Karta.Remove(karta);
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
