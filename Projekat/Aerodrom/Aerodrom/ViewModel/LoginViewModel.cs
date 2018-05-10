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
namespace Aerodrom.ViewModel
{
    class LoginViewModel
    {
        public String KorisnickoImeUnos{get; set;}
        public String LozinkaUnos { get; set; }
        public HomepageViewModel Parent { get; set; }
        public ICommand PrijaviSe { get; set; }
        public INavigationService NavigationService { get; set; }
        public LoginViewModel(HomepageViewModel parent)
        {
            NavigationService = new NavigationService();
            Parent = parent;
            PrijaviSe = new RelayCommand<object>(prijaviSe, mozeLiSePrijaviti);
        }

        public void prijaviSe(object parametar)
        {
            foreach (Korisnik k in KAerodrom.Korisnici)
            {
                
                if (k.KorisnickoIme.Equals(KorisnickoImeUnos) && k.Lozinka.Equals(LozinkaUnos))
                {
                    if (k.Priv == "Kupac")
                        NavigationService.Navigate(typeof(ProfilKorisnika), new ProfilKorisnikaViewModel(k));
                    else if (k.Priv == "Admin")
                        NavigationService.Navigate(typeof(AdminPanel), new AdminPanelViewModel(k));
                    else
                        NavigationService.Navigate(typeof(listaAdresa));
                    return;
                }
            }
            Messenger.prikaziPoruku("Ne postoji račun s unesenim podacima. Molimo pokušajte ponovo!");
        }

        public bool mozeLiSePrijaviti(object parametar)
        {
            return true;
        }
    }
}
