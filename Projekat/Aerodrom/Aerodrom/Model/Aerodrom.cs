using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Aerodrom.Model
{
    public class Aerodrom
    {
        List<Korisnik> korisnici;

        public Aerodrom()
        {
            Korisnici = new List<Korisnik>();
        }

        public Aerodrom(List<Korisnik> korisnici)
        {
            Korisnici = korisnici;
        }

        public List<Korisnik> Korisnici { get => korisnici; set => korisnici = value; }
    }
}
