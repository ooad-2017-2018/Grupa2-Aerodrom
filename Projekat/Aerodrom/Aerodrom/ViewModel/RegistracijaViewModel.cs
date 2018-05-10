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
using Windows.UI.Xaml;

namespace Aerodrom.ViewModel
{
    class RegistracijaViewModel
    {
        public HomepageViewModel Parent { get; set; }
        public ICommand DodavanjeKorisnika { get; set; }
        public ICommand OtkaziRegistraciju { get; set; }
        public Korisnik Korisnik { get; set; }

        public RegistracijaViewModel(HomepageViewModel parent)
        {
            Parent = parent;
            DodavanjeKorisnika = new RelayCommand<object>(dodavanjeKorisnika, mozeLiSeDodatiKorisnik);
            OtkaziRegistraciju = new RelayCommand<object>(otkaziRegistraciju, mozeLiSeOtkazatiRegistracija);
            Korisnik = new Korisnik();      
        }

        public void dodavanjeKorisnika(object parametar)
        {
            KAerodrom.Korisnici.Add(Korisnik);
            Messenger.prikaziPoruku("Korisnik je uspjesno registrovan!");
            Parent.NavigationService.GoBack();          
        }

        public bool mozeLiSeDodatiKorisnik(object parametar)
        {
            return true;
        }

        public void otkaziRegistraciju(object parametar)
        {
            //Otkazi, za sad izadji
            Parent.NavigationService.GoBack();
        }

        public bool mozeLiSeOtkazatiRegistracija(object parametar)
        {
            return true;
        }
    }
}
