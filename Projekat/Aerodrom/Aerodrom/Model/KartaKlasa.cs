using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerodrom.Model
{

    public class KartaKlasa
    {

        string prvaKlasa, businessKlasa, economyKlasa, uJednomSmjeru, PovratnaKarta;
        DateTime datumPolaska;
        DateTime datumPovratka;

        Destinacija destinacija;
        string sjediste, brojLeta;

        public KartaKlasa(string prvaKlasa, string businessKlasa, string economyKlasa, string uJednomSmjeru, string povratnaKarta, DateTime datumPolaska, DateTime datumPovratka, Destinacija destinacija, string sjediste, string brojLeta)
        {
            this.prvaKlasa = prvaKlasa;
            this.businessKlasa = businessKlasa;
            this.economyKlasa = economyKlasa;
            this.uJednomSmjeru = uJednomSmjeru;
            PovratnaKarta = povratnaKarta;
            this.datumPolaska = datumPolaska;
            this.datumPovratka = datumPovratka;
            this.destinacija = destinacija;
            this.sjediste = sjediste;
            this.brojLeta = brojLeta;
        }

        public string PrvaKlasa { get => prvaKlasa; set => prvaKlasa = value; }
        public string BusinessKlasa { get => businessKlasa; set => businessKlasa = value; }
        public string EconomyKlasa { get => economyKlasa; set => economyKlasa = value; }
        public string UJednomSmjeru { get => uJednomSmjeru; set => uJednomSmjeru = value; }
        public string PovratnaKarta1 { get => PovratnaKarta; set => PovratnaKarta = value; }
        public DateTime DatumPolaska { get => datumPolaska; set => datumPolaska = value; }
        public DateTime DatumPovratka { get => datumPovratka; set => datumPovratka = value; }
        public Destinacija Destinacija { get => destinacija; set => destinacija = value; }
        public string Sjediste { get => sjediste; set => sjediste = value; }
        public string BrojLeta { get => brojLeta; set => brojLeta = value; }
    }
}