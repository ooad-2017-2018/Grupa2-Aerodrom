using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Aerodrom.Helper;
using Aerodrom.ViewModel.Helper;
using Aerodrom.Model;
using Windows.UI.Popups;
using Aerodrom.View;
using Microsoft.WindowsAzure.MobileServices;
using Aerodrom.DB;
using Aerodrom.Helper;
using System.Data;

using System.Diagnostics;


namespace Aerodrom.ViewModel
{
    class LoginViewModel
    {
        IMobileServiceTable<KorisnikTabela> tabelaKorisnika = App.MobileService.GetTable<KorisnikTabela>();
        public String KorisnickoImeUnos { get; set; }
        public String LozinkaUnos { get; set; }
        public HomepageViewModel Parent { get; set; }
        public ICommand PrijaviSe { get; set; }
        public INavigationService NavigationService { get; set; }
       // public List<Korisnik> korisnici { get; set; }
        public LoginViewModel(HomepageViewModel parent)
        {
           // korisnici = new List<Korisnik>();
            
            NavigationService = new NavigationService();
            Parent = parent;
            PrijaviSe = new RelayCommand<object>(prijaviSe, mozeLiSePrijaviti);
        }

        public static Korisnik dajKorisnika(KorisnikTabela k)
        {
            Korisnik korisnik = new Korisnik();
            korisnik.Ime = k.ime;
            korisnik.Prezime = k.prezime;
            korisnik.Jmbg = k.jmbg;
            korisnik.KorisnickoIme = k.korisnickoIme;
            korisnik.Lozinka = k.lozinka;
            korisnik.Opcija12Mjeseci = k.opcija12Mjeseci;
            korisnik.Opcija1Mjesec = k.opcija1Mjesec;
            korisnik.Opcija6Mjeseci = k.opcija6Mjeseci;
            korisnik.Priv = k.priv;
            korisnik.Email = k.email;
            korisnik.DatumRodjenja = k.datumRodjenja;
            korisnik.BrojTelefona = k.brojTelefona;
            korisnik.BrojKreditneKartice = k.brojKreditneKartice;
            korisnik.AdresaStanovanja = k.adresaStanovanja;
            korisnik.Admin = k.admin;
            return korisnik;
        }

       
        public async void prijaviSe(object parametar)
        {
            Boolean nekiBool = true;
            List<KorisnikTabela> lista = await tabelaKorisnika.ToListAsync();
            KorisnikTabela kor = new KorisnikTabela();
            if (!lista.Any(x => x.korisnickoIme == KorisnickoImeUnos && x.lozinka == LozinkaUnos)) nekiBool = false;
            kor = lista.Find(x => x.korisnickoIme == KorisnickoImeUnos);             

            if (nekiBool)
            {             
                Korisnik korisnik = dajKorisnika(kor);
                if (korisnik.Priv == "Kupac")
                    NavigationService.Navigate(typeof(ProfilKorisnika), new ProfilKorisnikaViewModel(korisnik));
                else if (korisnik.Priv == "Admin")
                {
                    AdminPanelViewModel ap = new AdminPanelViewModel(korisnik);
                    foreach (KorisnikTabela kt in lista)
                    {
                        ap.Korisnici.Add(LoginViewModel.dajKorisnika(kt));
                    }

                    NavigationService.Navigate(typeof(AdminPanel), ap);
                }
                else
                    NavigationService.Navigate(typeof(listaAdresa));
                return;
            }
                else Messenger.prikaziPoruku("Ne postoji račun s unesenim podacima. Molimo pokušajte ponovo!");
        }

        public bool mozeLiSePrijaviti(object parametar)
        {
            return true;
        }
    }
}
