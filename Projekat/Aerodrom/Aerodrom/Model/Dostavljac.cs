using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Windows.System;

namespace Aerodrom.Model
{
    public class Dostavljac : Korisnik
    {
        float plata;
        string korisnickoIme, lozinka, emailAdresa;

        public Dostavljac(string ime, string prezime, string adresaStanovanja, string jmbg, string brojKreditneKartice, 
            DateTime datumRodjenja, int brojTelefona, float plata, string korIme, string lozinka, string emailAdresa) : base(ime, prezime,
                adresaStanovanja, jmbg, brojKreditneKartice, datumRodjenja, brojTelefona)
        {
            Plata = plata;
            KorisnickoIme1 = korIme;
            Lozinka1 = lozinka;
            EmailAdresa = emailAdresa;
        }

        public global::System.Single Plata { get => plata; set => plata = value; }
        public global::System.String KorisnickoIme1 { get => korisnickoIme; set => korisnickoIme = value; }
        public global::System.String Lozinka1 { get => lozinka; set => lozinka = value; }
        public global::System.String EmailAdresa { get => emailAdresa; set => emailAdresa = value; }
    }
}
