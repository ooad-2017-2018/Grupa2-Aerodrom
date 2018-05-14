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
       

        public Dostavljac(string ime, string prezime, string adresaStanovanja, string jmbg, string brojKreditneKartice, 
            DateTime datumRodjenja, int brojTelefona, float plata, string korIme, string lozinka, string emailAdresa) : base(ime, prezime,
                adresaStanovanja, jmbg, brojKreditneKartice, datumRodjenja, brojTelefona, emailAdresa, korIme, lozinka)
        {
            Plata = plata;
            
        }

        public global::System.Single Plata { get => plata; set => plata = value; }
       
    }
}
