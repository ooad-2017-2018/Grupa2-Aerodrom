using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aerodrom.Model;
using Aerodrom.Helper;
using System.Windows.Input;


namespace Aerodrom.ViewModel
{
    class AerodromViewModel 

    {
        public ICommand PrikaziKorisnika { get; set; }
        public ICommand DodajKorisnika { get; set; }
        public ICommand ObrisiKorisnika { get; set; }
        public ICommand PromijeniUloguKorisnika { get; set; }

        public AerodromViewModel()
        {
          /*  ObrisiKorisnika = new RelayCommand<object>(obrisiKorisnika);
            DodajKorisnika = new RelayCommand<object>(dodajKorisnika);
            PrikaziKorisnika = new RelayCommand<object>(prikaziKorisnika);
            PromijeniUloguKorisnika = new RelayCommand<object>(promijeniUloguKorisnika);*/
        }

    }
}
