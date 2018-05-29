using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Aerodrom.Model;
using Aerodrom.ViewModel.Helper;
using Aerodrom.Helper;
using Windows.UI.Core;
using Microsoft.WindowsAzure.MobileServices;
using Aerodrom.DB;

namespace Aerodrom.ViewModel
{
    class ProfilKorisnikaViewModel
    {
        IMobileServiceTable<KorisnikTabela> tabelaKorisnika = App.MobileService.GetTable<KorisnikTabela>();
        public ICommand OdjaviSe { get; set; }
        public ICommand SacuvajPromjene { get; set; }
        public Korisnik Korisnik { get; set; }
        public INavigationService NavigationService { get; set; }
        KorisnikTabela obj;

        public ProfilKorisnikaViewModel(Korisnik k, AdminPanelViewModel p = null)
        {
           
            NavigationService = new NavigationService();
            SacuvajPromjene = new RelayCommand<object>(sacuvajPromjene, moguLiSeSacuvatiPromjene);
            OdjaviSe = new RelayCommand<object>(odjaviSe, mozeLiSeOdjaviti);
            Korisnik = k;
            inicTab();
        }

        public async void inicTab()
        {
             obj= (await tabelaKorisnika.Where(x => x.korisnickoIme == Korisnik.KorisnickoIme).ToEnumerableAsync()).Single();
        }
        public async void sacuvajPromjene(object p)
        {
            
            /*foreach (Korisnik k in KAerodrom.Korisnici)
            {
                if (k.Id == Korisnik.Id)
                {
                    KAerodrom.Korisnici.Remove(k);
                    KAerodrom.Korisnici.Add(Korisnik);
                    Messenger.prikaziPoruku("Promjene uspjesno sačuvane.");
                    break;
                }
            }*/
            
            
            if (obj != null)
            {
                obj.ime = Korisnik.Ime;
                obj.prezime = Korisnik.Prezime;
                obj.korisnickoIme = Korisnik.KorisnickoIme;
                obj.lozinka = Korisnik.Lozinka;
                obj.datumRodjenja = Korisnik.DatumRodjenja;
                obj.brojTelefona = Korisnik.BrojTelefona;
                obj.brojKreditneKartice = Korisnik.BrojKreditneKartice;
                obj.adresaStanovanja = Korisnik.AdresaStanovanja;
                obj.opcija1Mjesec = Korisnik.Opcija1Mjesec;
                obj.opcija6Mjeseci = Korisnik.Opcija6Mjeseci;
                obj.opcija12Mjeseci = Korisnik.Opcija12Mjeseci;
                obj.admin = Korisnik.Admin;
                obj.priv = Korisnik.Priv;
                obj.jmbg = Korisnik.Jmbg;
                obj.email = Korisnik.Email;               
                await tabelaKorisnika.UpdateAsync(obj);
            }
        }

        public bool moguLiSeSacuvatiPromjene(object p)
        {
            return true;
        }

        public void odjaviSe(object p)
        {
            NavigationService.Navigate(typeof(Homepage), new HomepageViewModel());

        }

        public bool mozeLiSeOdjaviti(object p)
        {
            return true;
        }
    }
}
