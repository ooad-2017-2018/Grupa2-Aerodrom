using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerodrom.Model
{
   public class Dostava
    {
        List<KartaKlasa> karte;
        bool dostavljena;

        public Dostava(List<KartaKlasa> karte, global::System.Boolean dostavljena)
        {
            this.karte = karte;
            this.dostavljena = dostavljena;
        }

        public List<KartaKlasa> Karte { get => karte; set => karte = value; }
        public global::System.Boolean Dostavljena { get => dostavljena; set => dostavljena = value; }
    }
}
