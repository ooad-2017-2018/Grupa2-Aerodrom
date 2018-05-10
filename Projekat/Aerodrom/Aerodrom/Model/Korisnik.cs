using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Windows.System;

namespace Aerodrom.Model
{
    public class Korisnik
    {
        
        public List<String> Privilegije { get; set; }
        String ime, prezime, adresaStanovanja, jmbg, brojKreditneKartice, email, korisnickoIme, lozinka;
        DateTime datumRodjenja;
        Int32 brojTelefona;
        Int32 id;
        static Int32 brojac = 0;
        bool opcija1Mjesec, opcija6Mjeseci, opcija12Mjeseci, selektovan, admin;
        String priv;

        private void loadPriv()
        {
            Privilegije = new List<string>();
            Privilegije.Add("Kupac");
            Privilegije.Add("Admin");
            Privilegije.Add("Dostavljač");
            Priv = "Kupac";
            admin = false;
        }

        public Korisnik()
        {
            loadPriv();
            
            id = brojac++;
        }

        public Korisnik(string ime, string prezime, string adresaStanovanja, string jmbg, string brojKreditneKartice, DateTime datumRodjenja, int brojTelefona)
        {
            loadPriv(); 
            Ime = ime;
            Prezime = prezime;
            AdresaStanovanja = adresaStanovanja;
            Jmbg = jmbg;
            BrojKreditneKartice = brojKreditneKartice;
            DatumRodjenja = datumRodjenja;
            BrojTelefona = brojTelefona;
            
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
        public String Priv { get => priv; set { priv = value; if (value == "Admin") admin = true; } }
        public bool Selektovan { get => selektovan; set => selektovan = value; }
        public bool Admin { get => admin; set => admin = value; }
    }
}
