# Grupa2-Aerodrom


## Članovi tima:

1. Karim Alomerović
2. Nejra Imširović

## Opis teme:

Naš sistem omogućava korisnicima da elektronskim putem rezervišu kartu za let. Kartu su u mogućnosti kupiti i guest korisnici i registrovani članovi. Registrovani članovi plaćaju članarinu pri čemu mogu izabrati da li žele plaćati mjesečnu članarinu, članarinu za 6 mjeseci ili za 12 mjeseci, s tim da ostvaruju odgovarajuću uštedu biranjem dužeg plana. Također, registrovani članovi imaju mogućnost da ostvare dodatne pogodnosti i da primaju obavještenja na svoju email adresu. Nakon kupovine, karta se dostavlja na adresu korisnika. Na kartama se nalazi QR code koji nas vodi na stranicu na kojoj se nalazi opis naše destinacije koji uključuje spisak 
popularnih smještaja, znamenitosti grada u koji naš korisnik odlazi kao i popularna mjesta za izlazak(restorani, pozorista...).
Sistem će olakšati kupovinu karata u smislu da možemo kupiti kartu iz udobnosti vlastitog doma.

## Procesi:

Korisniku prvo biva predstavljena početna stranica gdje su mu ponuđene tri opcije: login, registracija i kupovina karte.

### Login

Ako već imamo račun u sistemu, u mogućnosti smo prijaviti se putem login forme koja sadrži polja za sljedeće podatke:
- username
- password
- login dugme kojim potvrđujemo unos te bivamo usmjereni na formu u kojoj popunjavamo podatke o željenom letu koja će biti kasnije opisana
U svakom trenutku je moguće odustati od prijave klikom na dugme "otkaži" čime bivamo vraćeni na početnu stranicu

### Registracija

Ako nemamo račun u sistemu, u mogućnosti smo kreirati ga putem forme za registraciju koja sadrži polja za sljedeće podatke:
- ime
- prezime
- korisnicko ime
- datum rođenja
- jmbg
- adresa stanovanja
- broj telefona
- e-mail adresa
- tri opcije plana plaćanja članarine:
  - jedan mjesec
  - šest mjeseci
  - jedna godina
- broj kreditne kartice
- dugme kojim potvrđujemo svoj unos kojim kreiramo račun i bivamo usmjereni na početnu stranicu kao prijavljeni (login-ovani) korisnik
Korisnik u svakom trenutku može odustati od registracije klikom na dugme "otkaži" pri čemu biva vraćen na početnu stranicu a svi uneseni podaci bivaju obrisani

### Kupovina karte

Forma za popunjavanje podataka o željenom letu je u suštini ista za goste i članove s malim razlikama. Sadrži polja za sljedeće podatke:

- opcije
  - u jednom smjeru
  - povratno
- datum polaska
- datum povratka (vidljivo samo u slučaju da smo odabrali opciju povratno)
- destinacija
  - država
  - grad
- klasa
- grafički prikaz rasporeda sjedišta u avionu (opcija dostupna samo članovima)
- adresa stanovanja (vidljivo samo gostima obzirom da je to nepoznat, a potreban podatak kad su gosti u pitanju)

Dugme kojim potvrđujemo kupovinu karte i kojim stupamo u interakciju sa bankovnim računom korisnika. U ovom trenutku moguće je da zahtjev za plaćanje bude odbijen (nedovoljno sredstava na računu, greška u bankovnom sistemu...)
U svakom trenutku je moguće odustati od kupovine karte klikom na dugme "otkaži" pri čemu bivamo vraćeni na početnu stranicu.

### Slanje obavještenja članovima na email adresu

Članovi primaju određena obavještenja na email adresu od strane sistema ili administratora sistema. Obavještenja uključuju, ali nisu nužno ograničena na:
- informacije o ostvarenom pupustu 
- informacije o promjenama u sistemu
- informacije vezane za let (otkazan, pomjeren..)
- informacije o isteku članarine
- posebne ponude

### Dostavljanje karte korisniku na adresu

Nakon poslanog zahtjeva za kartu, ona biva isprintana i poslana korisniku na adresu

### Prikaz informacija o destinaciji 

Na karti se nalazi QR kod čijim skeniranjem bivamo odvedeni na web stranicu koja nam daje kratak opis naše destinacije prikupljanjem podataka iz raznih turističkih agencija (popularne lokacije, smještaji itd...).

## Funkcionalnosti

- Login u slučaju da imamo račun
- Registrovanje novog računa
- Kupovina karte
- Slanje obavještenja članovima na email adresu
- Dostavljanje karte korisniku na adresu
- Prikaz informacija o destinaciji sa karte nakon skeniranja QR koda

## Akteri 

- Korisnik - registrovani član ili guest korisnik sistema
- Dostavljač - osoba koja dostavlja kupljenu kartu na odgovarajuću adresu
- Sistem za interakciju s bankom u kojoj korisnik ima račun
- Administrator sistema - održava sistem i eventualno šalje neautomatizirane poruke korisnicima sistema
