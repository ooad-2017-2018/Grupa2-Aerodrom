using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aerodrom.Model;
using System.Windows.Input;

namespace Aerodrom.ViewModel
{
    public class AdminPanelViewModel
    {
        public ICommand PrikaziKorisnika { get; set; }
        public ICommand DodajKorisnika { get; set; }
        public ICommand ObrisiKorisnika { get; set; }
        public ICommand PromijeniUloguKorisnika { get; set; }

        public AdminPanelViewModel()
        {/*
            ObrisiKorisnika = new RelayCommand<object>(obrisiKorisnika);
            DodajKorisnika = new RelayCommand<object>(dodajKorisnika);
            PrikaziKorisnika = new RelayCommand<object>(prikaziKorisnika);
            PromijeniUloguKorisnika = new RelayCommand<object>(promijeniUloguKorisnika);*/
        }

    }
}
