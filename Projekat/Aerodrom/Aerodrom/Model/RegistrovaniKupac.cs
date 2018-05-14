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

        
        PlanPlacanja planPlacanja;

        public RegistrovaniKupac(string ime, string prezime, string adresaStanovanja, string jmbg, string brojKreditneKartice,
            DateTime datumRodjenja, int brojTelefona, string korisnickoIme, string lozinka, string emailAdresa, PlanPlacanja planPlacanja) :
             base(ime, prezime, adresaStanovanja, jmbg, brojKreditneKartice, datumRodjenja, brojTelefona, emailAdresa, korisnickoIme, lozinka)
        {
           
            this.planPlacanja = planPlacanja;
        }

       
        internal PlanPlacanja PlanPlacanja { get => planPlacanja; set => planPlacanja = value; }
    }
}
