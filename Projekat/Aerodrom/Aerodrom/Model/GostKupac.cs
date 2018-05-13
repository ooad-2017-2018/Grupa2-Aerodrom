using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerodrom.Model
{
    public class GostKupac : Korisnik
    {
        Karta karta;
        public GostKupac(string ime, string prezime, string adresaStanovanja, string jmbg, string brojKreditneKartice, 
            DateTime datumRodjenja, int brojTelefona, Karta karta) : base(ime, prezime, adresaStanovanja, jmbg, brojKreditneKartice, datumRodjenja, brojTelefona)
        { }

        public Karta Karta { get => karta; set => karta = value; }
    }
}
