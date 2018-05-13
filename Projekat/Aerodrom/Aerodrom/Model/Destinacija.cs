using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerodrom.Model
{
    public class Destinacija
    {
        string drzava, grad;
        int cijena;

        public Destinacija(global::System.String drzava, global::System.String grad, global::System.Int32 cijena)
        {
            this.drzava = drzava;
            this.grad = grad;
            this.cijena = cijena;
        }

        public Destinacija() { }

        public global::System.String Drzava { get => drzava; set => drzava = value; }
        public global::System.String Grad { get => grad; set => grad = value; }
        public global::System.Int32 Cijena { get => cijena; set => cijena = value; }
    }
}
