namespace Aerodrom.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Web.Helpers;

    [Table("Karta")]
    public partial class Karta
    {
        public int KartaId { get; set; }

        [Required]
        public string TipKarte { get; set; }

        public DateTime DatumPolaska { get; set; }

        public DateTime DatumPovratka { get; set; }

        [Required]
        public string Destinacija { get; set; }

        [Required]
        public string Klasa { get; set; }

        [Required]
        public string Sjediste { get; set; }

        [Required]
        public string BrojLeta { get; set; }

        [Required]
        public string AdresaKupca { get; set; }

        public string Kupac { get; set; }

        public int? Dostava_DostavaId { get; set; }
           
    }
}
