using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Aerodrom.Models
{
    public class Dostava
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DostavaId { get; set; }
        public String Kupac { get; set; }
        public virtual ICollection<Karta> Karta { get; set; }
    }
}