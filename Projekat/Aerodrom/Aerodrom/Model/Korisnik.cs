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
        public enum Privilegija { Admin, Dostavljac, Kupac}
        String ime, prezime, adresaStanovanja, jmbg, brojKreditneKartice, email, korisnickoIme, lozinka;
        DateTime datumRodjenja;
        Int32 brojTelefona;
        Int32 id;
        static Int32 brojac = 0;
        bool opcija1Mjesec, opcija6Mjeseci, opcija12Mjeseci;
        Privilegija priv;

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
            Priv = Privilegija.Kupac;
            id = brojac++;
        }

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string AdresaStanovanja { get => adresaStanovanja; set => adresaStanovanja = value; }
        public string Jmbg { get => jmbg; set => jmbg = value; }
        public string BrojKreditneKartice { get => brojKreditneKartice; set => brojKreditneKartice = value; }
        public DateTime DatumRodjenja
        {
            get => datumRodjenja; set => datumRodjenja = value;
        }
        public int BrojTelefona { get => brojTelefona; set => brojTelefona = value; }
        public string Email { get => email; set => email = value; }
        public string KorisnickoIme { get => korisnickoIme; set => korisnickoIme = value; }
        public string Lozinka { get => lozinka; set => lozinka = value; }
        public bool Opcija1Mjesec { get => opcija1Mjesec; set => opcija1Mjesec = value; }
        public bool Opcija6Mjeseci { get => opcija6Mjeseci; set => opcija6Mjeseci = value; }
        public bool Opcija12Mjeseci { get => opcija12Mjeseci; set => opcija12Mjeseci = value; }
        public int Id { get => id; }
        public Privilegija Priv { get => priv; set => priv = value; }
    }
}
