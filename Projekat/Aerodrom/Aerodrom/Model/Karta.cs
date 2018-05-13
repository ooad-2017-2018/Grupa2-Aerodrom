using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerodrom.Model
{
    public enum TipKlase { prva, business, economy};
    public enum TipKarte { uJednomSmjeru, PovratnaKarta};

   public class Karta
    {
        TipKarte tipKarte;
        DateTime datumPolaska;
        DateTime datumPovratka;
        TipKlase klasa;
        Destinacija destinacija;
        string sjediste, brojLeta;

        public Karta(TipKarte tipKarte, DateTime datumPolaska, DateTime datumPovratka, TipKlase klasa, Destinacija destinacija, string sjediste, string brojLeta)
        {
            this.tipKarte = tipKarte;
            this.datumPolaska = datumPolaska;
            this.datumPovratka = datumPovratka;
            this.klasa = klasa;
            this.destinacija = destinacija;
            this.sjediste = sjediste;
            this.brojLeta = brojLeta;
        }

        public TipKarte TipKarte { get => tipKarte; set => tipKarte = value; }
        public DateTime DatumPolaska { get => datumPolaska; set => datumPolaska = value; }
        public DateTime DatumPovratka { get => datumPovratka; set => datumPovratka = value; }
        public TipKlase Klasa { get => klasa; set => klasa = value; }
        public Destinacija Destinacija { get => destinacija; set => destinacija = value; }
        public string Sjediste { get => sjediste; set => sjediste = value; }
        public string BrojLeta { get => brojLeta; set => brojLeta = value; }
    }
}
