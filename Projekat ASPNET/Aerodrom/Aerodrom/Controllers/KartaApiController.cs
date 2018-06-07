using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using Aerodrom.Models;

namespace Aerodrom.Controllers
{
    public class KartaApiController : ApiController
    {
        private AerodromModel db = new AerodromModel();

        // GET: api/KartaApi
        public IQueryable<Karta> GetKartas()
        {
            return db.Kartas;
        }

        // GET: api/KartaApi/5
        [ResponseType(typeof(Karta))]
        public async Task<IHttpActionResult> GetKarta(int id)
        {
            Karta karta = await db.Kartas.FindAsync(id);
            if (karta == null)
            {
                return NotFound();
            }

            return Ok(karta);
        }

        // PUT: api/KartaApi/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutKarta(int id, Karta karta)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != karta.KartaId)
            {
                return BadRequest();
            }

            db.Entry(karta).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KartaExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/KartaApi
        [ResponseType(typeof(Karta))]
        public async Task<IHttpActionResult> PostKarta(Karta karta)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Kartas.Add(karta);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = karta.KartaId }, karta);
        }

        // DELETE: api/KartaApi/5
        [ResponseType(typeof(Karta))]
        public async Task<IHttpActionResult> DeleteKarta(int id)
        {
            Karta karta = await db.Kartas.FindAsync(id);
            if (karta == null)
            {
                return NotFound();
            }

            db.Kartas.Remove(karta);
            await db.SaveChangesAsync();

            return Ok(karta);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool KartaExists(int id)
        {
            return db.Kartas.Count(e => e.KartaId == id) > 0;
        }
    }
}