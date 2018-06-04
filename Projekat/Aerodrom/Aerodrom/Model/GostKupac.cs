using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerodrom.Model
{
    public class GostKupac : Korisnik
    {
        KartaKlasa karta;
        public GostKupac(string ime, string prezime, string adresaStanovanja, string jmbg, string brojKreditneKartice, 
            DateTime datumRodjenja, int brojTelefona, KartaKlasa karta) : base(ime, prezime, adresaStanovanja, jmbg, brojKreditneKartice, datumRodjenja, brojTelefona)
        { }

        public KartaKlasa Karta { get => karta; set => karta = value; }
    }
}
