using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Aerodrom.Helper;
using Aerodrom.Model;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;

namespace Aerodrom.ViewModel
{
    class HomepageViewModel
    {
        public INavigationService NavigationService { get; set; }
        public ICommand OtvoriRegistraciju { get; set; }
        public ICommand OtvoriLogin { get; set; }     

        public HomepageViewModel()
        {          
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
