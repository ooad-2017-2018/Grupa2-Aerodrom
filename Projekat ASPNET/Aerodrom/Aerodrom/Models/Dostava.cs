using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aerodrom.Models
{
    public class Dostava
    {
        String idKupca;
        public virtual ICollection<Karta> Karta { get; set; }
    }
}