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
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Microsoft.WindowsAzure.MobileServices;
using Aerodrom.DB;

namespace Aerodrom.ViewModel
{
    class RegistracijaViewModel : INotifyPropertyChanged
    {
        
        IMobileServiceTable<KorisnikTabela> userTableObj = App.MobileService.GetTable<KorisnikTabela>();

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
            Korisnik.ErrorsChanged += Vm_ErrorsChanged;
        }

        public async void dodavanjeKorisnika(object parametar)
        {

            if ((Korisnik.Opcija12Mjeseci || Korisnik.Opcija1Mjesec || Korisnik.Opcija6Mjeseci) && Korisnik.Errors.Errors.Count == 0)
            {
                try
                {
                    KorisnikTabela obj = dajObjekat(Korisnik);

                    List<KorisnikTabela> lista = await userTableObj.ToListAsync();
                    if (lista.Count() == 0) { obj.priv = "Admin"; obj.admin = true; }

                    await userTableObj.InsertAsync(obj);

                    Messenger.prikaziPoruku("Korisnik je uspjesno registrovan!");
                    Parent.NavigationService.GoBack();
                }
                catch (Exception ex)
                {
                    Messenger.prikaziPoruku("Izuzetak:" + ex.Message);
                }
            }
            else
            {
                Messenger.prikaziPoruku("Niste popunili sva polja ili odabrali potrebne opcije.");
            }
                      
        }

        public static KorisnikTabela dajObjekat(Korisnik Korisnik)
        {
            KorisnikTabela obj = new KorisnikTabela();

            obj.ime = Korisnik.Ime;
            obj.prezime = Korisnik.Prezime;
            obj.adresaStanovanja = Korisnik.AdresaStanovanja;
            obj.brojKreditneKartice = Korisnik.BrojKreditneKartice;
            obj.brojTelefona = Korisnik.BrojTelefona;
            obj.datumRodjenja = Korisnik.DatumRodjenja;
            obj.email = Korisnik.Email;
            obj.korisnickoIme = Korisnik.KorisnickoIme;
            obj.lozinka = Korisnik.Lozinka;
            obj.opcija12Mjeseci = Korisnik.Opcija12Mjeseci;
            obj.opcija6Mjeseci = Korisnik.Opcija6Mjeseci;
            obj.opcija1Mjesec = Korisnik.Opcija1Mjesec;
            obj.priv = Korisnik.Priv;
            obj.admin = Korisnik.Admin;
            obj.jmbg = Korisnik.Jmbg;

            return obj;
        }

        public void brisanjeKorisnika(object parametar)
        {
            

            
        }
        public bool mozeLiSeDodatiKorisnik(object parametar)
        {
            return true;
        }

        public void otkaziRegistraciju(object parametar)
        {
            
            Parent.NavigationService.GoBack();
        }

        public bool mozeLiSeOtkazatiRegistracija(object parametar)
        {
            return true;
        }

        private void Vm_ErrorsChanged(object sender, System.ComponentModel.DataErrorsChangedEventArgs e)
        {
            //event koji ce se pozvati kad dodje do neispravne validacije
            //daj sve greske i pretvori ih u listu stringova da se mogu ispisati
            Erori = new ObservableCollection<string>(Korisnik.Errors.Errors.Values.SelectMany(x => x).ToList());
        }

        private ObservableCollection<string> erori;
        public ObservableCollection<string> Erori { get { return erori; } set { erori = value; OnNotifyPropertyChanged("Erori"); } }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnNotifyPropertyChanged([CallerMemberName] string memberName = "")
        {
            //? je skracena verzija ako nije null
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(memberName));
        }



    }
}
