using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerodrom.Model
{
    public enum PlanPlacanja { Mjesec, Mjeseci6, Mjeseci12 };

    public class RegistrovaniKupac : Korisnik
    {     

        string korisnickoIme, lozinka, emailAdresa;
        PlanPlacanja planPlacanja;

        public RegistrovaniKupac(string ime, string prezime, string adresaStanovanja, string jmbg, string brojKreditneKartice,
            DateTime datumRodjenja, int brojTelefona, string korisnickoIme, string lozinka, string emailAdresa, PlanPlacanja planPlacanja) :
             base(ime, prezime, adresaStanovanja, jmbg, brojKreditneKartice, datumRodjenja, brojTelefona)
        {
            this.korisnickoIme = korisnickoIme;
            this.lozinka = lozinka;
            this.emailAdresa = emailAdresa;
            this.planPlacanja = planPlacanja;
        }

        public string KorisnickoIme1 { get => korisnickoIme; set => korisnickoIme = value; }
        public string Lozinka1 { get => lozinka; set => lozinka = value; }
        public string EmailAdresa { get => emailAdresa; set => emailAdresa = value; }
        internal PlanPlacanja PlanPlacanja { get => planPlacanja; set => planPlacanja = value; }
    }
}
