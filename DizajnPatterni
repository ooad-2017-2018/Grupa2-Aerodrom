# Dizaj paterni

## Singleton 

### Kada se koristi

Koristi se kada nam je potrebna klasa koja će biti instancirana samo jedanput i kojoj je osiguran globalni pristup. Sadrži privatni static read-only objekat kojeg instanciramo u konstruktoru, privatni static konstruktor te public static metodu koja služi za pristup spomentuom private static read-only objektu kojeg jos i instancira ako vec to nije ucinjeno.

### U nasem projektu

Postoji klasa KAerodrom koja predstavlja kontejnersku klasu. Uvođenjem veze aplikacije sa bazom postaje upitna iskoristivost ove klase, ali je našla svoju primjenu u ranim fazama razvoja i testiranja aplikacije.

## Facade

### Kada se koristi

Glavna primjena ovog paterna je pružanje pogleda visokog nivoa na određene podsisteme, odnosno služi za kreiranje različitih, pojednostavljenih pogleda na podsistem, ovisno od potrebe. Moguće je postavljanje više fasada oko jednog ili skupa podsistema i kreirati više pogleda.

### U nasem projektu

U nasem projektu se nije koristio ovaj pattern

## Proxy

Namjena Proxy paterna je da omogući pristup i kontrolu pristupa stvarnim objektima. Proxy je obično
mali javni surogat objekat koji predstavlja kompleksni objekat čija aktivizacija se postiže na osnovu
postavljenih pravila. Proxy patern rješava probleme kada se objekt ne može instancirati direktno (npr.
zbog restrikcije pristupa). 

### U nasem projektu

Još uvijek nije našao primjenu, ali će ga možda biti moguće iskoristiti u radu sa bazom podataka

## TemplateMethod pattern

### Kada se koristi

TemplateMethod pattern omogućava izdvajanje određenih koraka algoritma u odvojene podklase. Struktura samog algoritma se ne mijenja (mali dijelovi operacija se izdvajaju i ti se dijelovi mogu implementirati različito).

### U našem projektu

Ovaj pattern se može iskoristiti u našem projektu u dijelu za kupovinu karte. Naime, metoda za naplaćivanje karte se može izdvojiti u interface čije metode onda implementira zasebna klasa. Nakon toga, klasa i metode za kupovinu karte mogu pozivati tu metodu.

## Observer pattern

### Kada se koristi

Uloga Observer patterna je da uspostavi relaciju između objekata tako da kada jedan objekat promijeni stanje, drugi zainteresirani
objekti se obavještavaju. Npr. ukoliko nam se sviđa određena stranica na nekoj društvenoj mreži, mi se možemo prijaviti da nam stižu obavještenja kada bude neki novi post na toj stranici.

### U našem projektu

Naš projekat nudi opciju za svoje registrovane korisnike da primaju obavještenja na email o nekim ponudama, popustima i slično. Ovaj pattern bi svoju primjenu mogao pronaći upravo ovdje.

## Flyweight pattern

### Kada se koristi

Ponekad je potrebno da razdvojimo dio klase koji je isti za sve objekte te klase (tzv. glavno stanje ili engl. intrinsic state) od dijela klase koji nije uvijek isti za sve određene objekte (tzv. sporedno stanje ili engl. extrinsic state). Npr. ukoliko imamo klasu restoran možemo koristiti ovaj pattern kod naručivanja hrane jer svaki gost ne mora naručivati isto jelo (taj dio se razlikuje za svakog gosta).

### U našem projektu

Ovaj pattern još uvijek nije našao svoju primjenu u našem projektu, ali bi mogao naći u metodi koja računa cijenu karte jer cijena karte ne mora biti ista za registrovanog kupca i za guest kupca (registrovani kupac ima određene popuste i pogodnosti).

