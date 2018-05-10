using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Aerodrom.Model
{
    public class KAerodrom
    {
        static List<Korisnik> korisnici = new List<Korisnik>();

        public static List<Korisnik> Korisnici { get => korisnici; set => korisnici = value; }
    }
}
