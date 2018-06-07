namespace Aerodrom.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KorisnikTabela")]
    public partial class KorisnikTabela
    {
        [StringLength(255)]
        public string id { get; set; }

        public DateTimeOffset createdAt { get; set; }

        public DateTimeOffset? updatedAt { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] version { get; set; }

        public bool? deleted { get; set; }

        public string ime { get; set; }

        public string prezime { get; set; }

        public string adresaStanovanja { get; set; }

        public string jmbg { get; set; }

        public string brojKreditneKartice { get; set; }

        public string email { get; set; }

        public string korisnickoIme { get; set; }

        public string lozinka { get; set; }

        public DateTimeOffset? datumRodjenja { get; set; }

        public double? brojTelefona { get; set; }

        public bool? opcija1Mjesec { get; set; }

        public bool? opcija6Mjeseci { get; set; }

        public bool? admin { get; set; }

        public string priv { get; set; }

        public bool? opcija12Mjeseci { get; set; }
    }
}
