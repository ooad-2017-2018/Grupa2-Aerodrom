using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Aerodrom.Models
{
    public class Karta
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int KartaId { get; set; }
        [Required(ErrorMessage ="Tip karte je neophodan")]
        public String TipKarte { get; set; }
        [Required(ErrorMessage = "Datum polaska je neophodan")]
        public DateTime DatumPolaska { get; set; }
        [Required(ErrorMessage = "Datum povratka je neophodan")]
        public DateTime DatumPovratka { get; set; }
        [Required(ErrorMessage = "Destinacija je neophodna")]
        public String Destinacija { get; set; }
        [Required(ErrorMessage = "Klasa je neophodna")]
        public String Klasa { get; set; }
        [Required(ErrorMessage = "Sjediste je neophodno")]
        public String Sjediste { get; set; }
        [Required(ErrorMessage = "Broj je neophodan")]
        public String BrojLeta { get; set; }
        [Required(ErrorMessage = "Adresa je neophodna.")]
        public String AdresaKupca { get; set; }
        public String Kupac { get; set; }
    }
}