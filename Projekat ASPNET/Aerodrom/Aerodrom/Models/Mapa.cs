using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Aerodrom.Models
{
    public class Mapa
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MapaId { get; set; }
    }
}