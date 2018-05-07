using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Aerodrom.Model
{
    public class Korisnik
    {
        String ime, prezime, adresaStanovanja, jmbg, brojKreditneKartice;
        DateTime datumRodjenja;
        Int32 brojTelefona;

        public Korisnik() { }

        public Korisnik(string ime, string prezime, string adresaStanovanja, string jmbg, string brojKreditneKartice, DateTime datumRodjenja, int brojTelefona)
        {
            Ime = ime;
            Prezime = prezime;
            AdresaStanovanja = adresaStanovanja;
            Jmbg = jmbg;
            BrojKreditneKartice = brojKreditneKartice;
            DatumRodjenja = datumRodjenja;
            BrojTelefona = brojTelefona;
        }

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string AdresaStanovanja { get => adresaStanovanja; set => adresaStanovanja = value; }
        public string Jmbg { get => jmbg; set => jmbg = value; }
        public string BrojKreditneKartice { get => brojKreditneKartice; set => brojKreditneKartice = value; }
        public DateTime DatumRodjenja { get => datumRodjenja; set => datumRodjenja = value; }
        public int BrojTelefona { get => brojTelefona; set => brojTelefona = value; }
    }
}
