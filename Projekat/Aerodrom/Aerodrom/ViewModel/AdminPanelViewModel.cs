using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aerodrom.Model;
using System.Windows.Input;
using Aerodrom.Helper;
using Microsoft.WindowsAzure.MobileServices;
using Aerodrom.DB;
using Aerodrom.ViewModel.Helper;
using Windows.UI.Xaml.Controls;
using System.Collections.ObjectModel;

namespace Aerodrom.ViewModel
{
    class AdminPanelViewModel
    {
        public String Poruka { get; set; }
        public List<String> Primaoci { get; set; }
        public ObservableCollection<Korisnik> Korisnici { get; set; }
        public bool SviDostavljaci { get; set; }
        public bool SviKupci { get; set; }
        public bool SviAdmini { get; set; }
        public Korisnik Korisnik { get; set; }
        public INavigationService NavigationService { get; set; }
        public ICommand OtvoriProfil { get; set; }
        public ICommand PosaljiPoruku { get; set; }
        public ICommand ObrisiKorisnika { get; set; }
        public ICommand IzmijeniPrivilegiju { get; set; }
        public ICommand OtkaziSlanje { get; set; }
        IMobileServiceTable<KorisnikTabela> tabelaKorisnika = App.MobileService.GetTable<KorisnikTabela>();

        public AdminPanelViewModel(Korisnik k)
        {
            Korisnik = k;
            Korisnici = new ObservableCollection<Korisnik>();
            OtvoriProfil = new RelayCommand<object>(otvoriProfil, mozeLiSeOtvoritiProfil);
            PosaljiPoruku = new RelayCommand<object>(posaljiPoruku, mozeLiSePoslatiPoruka);
            ObrisiKorisnika = new RelayCommand<object>(obrisiKorisnika, mozeLiSeObrisatiKorisnik);
            IzmijeniPrivilegiju = new RelayCommand<object>(izmijeniPriviliegiju, mozeLiSeIzmijenitiPrivilegija);
            OtkaziSlanje = new RelayCommand<object>(otkaziSlanje, mozeLiSeOtkazatiSlanje);
            NavigationService = new NavigationService();           
        }

        public void otvoriProfil(object p)
        {
            NavigationService.Navigate(typeof(ProfilKorisnika), new ProfilKorisnikaViewModel(Korisnik));
        }

        public bool mozeLiSeOtvoritiProfil(object p)
        {
            return true;
        }


        public void posaljiPoruku(object p)
        {

        }

        public bool mozeLiSePoslatiPoruka(object p)
        {
            return true;
        }
        public void otkaziSlanje(object p)
        {

        }

        public bool mozeLiSeOtkazatiSlanje(object p)
        {
            return true;
        }

        public async void obrisiKorisnika(object o)
        {
            foreach (Korisnik k in Korisnici.ToList())
            {
                if (k.Selektovan)
                {
                    var obj = (await tabelaKorisnika.Where(p => p.korisnickoIme == k.KorisnickoIme).ToEnumerableAsync()).Single();
                    if (obj != null)
                    {
                        //obj.priv = Priv;
                        await tabelaKorisnika.DeleteAsync(obj);
                        Korisnici.Remove(k);
                    }
                }
            }          
        }

        public bool mozeLiSeObrisatiKorisnik(object p)
        {
            return true;
        }
        public void izmijeniPriviliegiju(object p)
        {
            //Messenger.prikaziPoruku("OK");
        }

        public bool mozeLiSeIzmijenitiPrivilegija(object p)
        {
            return true;
        }
    }
}
