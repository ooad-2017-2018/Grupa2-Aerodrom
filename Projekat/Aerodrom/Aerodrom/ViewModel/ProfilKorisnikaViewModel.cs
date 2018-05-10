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

namespace Aerodrom.ViewModel
{
    class ProfilKorisnikaViewModel
    {
        public ICommand OdjaviSe { get; set; }
        public ICommand SacuvajPromjene { get; set; }
        public Korisnik Korisnik { get; set; }
        public INavigationService NavigationService { get; set; }

        public ProfilKorisnikaViewModel(Korisnik k, AdminPanelViewModel p = null)
        {
           
            NavigationService = new NavigationService();
            SacuvajPromjene = new RelayCommand<object>(sacuvajPromjene, moguLiSeSacuvatiPromjene);
            OdjaviSe = new RelayCommand<object>(odjaviSe, mozeLiSeOdjaviti);
            Korisnik = k;
        }

        public void sacuvajPromjene(object p)
        {
            foreach (Korisnik k in KAerodrom.Korisnici)
            {
                if (k.Id == Korisnik.Id)
                {
                    KAerodrom.Korisnici.Remove(k);
                    KAerodrom.Korisnici.Add(Korisnik);
                    Messenger.prikaziPoruku("Promjene uspjesno sačuvane.");
                    break;
                }
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
