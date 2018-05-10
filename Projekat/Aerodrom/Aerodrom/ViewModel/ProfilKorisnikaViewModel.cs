using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Aerodrom.Model;
using Aerodrom.ViewModel.Helper;
using Aerodrom.Helper;

namespace Aerodrom.ViewModel
{
    class ProfilKorisnikaViewModel
    {
        public ICommand SacuvajPromjene { get; set; }
        public Korisnik Korisnik { get; set; }

        public ProfilKorisnikaViewModel(Korisnik k)
        {
            SacuvajPromjene = new RelayCommand<object>(sacuvajPromjene, moguLiSeSacuvatiPromjene);
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
    }
}
