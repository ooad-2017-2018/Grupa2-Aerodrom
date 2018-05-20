using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Aerodrom.DB
{
    class KorisnikTabela
    {
        public string id { get; set; }
        public String ime { get; set; }
        public String prezime { get; set; }
        public String adresaStanovanja { get; set; }
        public String jmbg { get; set; }
        public String brojKreditneKartice { get; set; }
        public String email { get; set; }
        public String korisnickoIme { get; set; }
        public String lozinka { get; set; }
        public DateTime datumRodjenja { get; set; }
        public int brojTelefona { get; set; }       
        public bool opcija1Mjesec { get; set; }
        public bool opcija6Mjeseci { get; set; }
        public bool opcija12Mjeseci { get; set; }
        public bool admin { get; set; }
        public String priv { get; set; }
        public DateTime updatedAt { get; set; }
        
    }
}
