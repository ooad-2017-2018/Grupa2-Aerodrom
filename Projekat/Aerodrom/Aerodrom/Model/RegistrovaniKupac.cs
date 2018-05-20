using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerodrom.Model
{
    

    public class RegistrovaniKupac : Korisnik
    {
        private string planPlacanja;

        public RegistrovaniKupac(string ime, string prezime, string adresaStanovanja, string jmbg, string brojKreditneKartice,
            DateTime datumRodjenja, int brojTelefona, string korisnickoIme, string lozinka, string emailAdresa, string planPlacanja) :
             base(ime, prezime, adresaStanovanja, jmbg, brojKreditneKartice, datumRodjenja, brojTelefona, emailAdresa, korisnickoIme, lozinka)
        {
           
            this.planPlacanja = planPlacanja;
        }

       
        public string PlanPlacanja { get => planPlacanja; set => planPlacanja = value; }
    }
}
