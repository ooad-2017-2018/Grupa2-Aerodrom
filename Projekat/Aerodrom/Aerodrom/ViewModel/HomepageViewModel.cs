using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Aerodrom.Helper;
using Aerodrom.Model;

namespace Aerodrom.ViewModel
{
    class HomepageViewModel
    {
        public INavigationService NavigationService { get; set; }
        public ICommand OtvoriRegistraciju { get; set; }
        public ICommand OtvoriLogin { get; set; }

        public HomepageViewModel()
        {
            Korisnik admin = new Korisnik("Karim", "Alomerovic", "Hamida Besirevica 97", "1234567890123", "1234", new DateTime(1997,12,16), 123123123);
            admin.KorisnickoIme = "a";
            admin.Lozinka = "a";
            admin.Priv = "Admin";
            if (KAerodrom.Korisnici.Count() == 0)
                KAerodrom.Korisnici.Add(admin);
            OtvoriRegistraciju = new RelayCommand<object>(otvoriRegistraciju, mozeLiSeOtvoritiRegistracija);
            OtvoriLogin = new RelayCommand<object>(otvoriLogin, mozeLiSeOtvoritiLogin);
            NavigationService = new NavigationService();
        }

        public void otvoriRegistraciju(object parametar)
        {
            NavigationService.Navigate(typeof(Registracija), new RegistracijaViewModel(this));
        }

        public bool mozeLiSeOtvoritiRegistracija(object parametar)
        {
            return true;
        }

        public void otvoriLogin(object parametar)
        {
            NavigationService.Navigate(typeof(MainPage), new LoginViewModel(this));
        }

        public bool mozeLiSeOtvoritiLogin(object parametar)
        {
            return true;
        }
    }
}
