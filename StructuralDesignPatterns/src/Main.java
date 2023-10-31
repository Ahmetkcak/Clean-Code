import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

public class Main {
    public static void main(String[] args) {


        // Adapter Tasarım Deseni
        EskiUSB eskiUSB = new EskiUSB();
        YeniUSB yeniUSB = new USBAdapter(eskiUSB);
        yeniUSB.baglantiKur();


        // Bridge Tasarım Deseni
        CizimAPI kalemCizimAPI = new KalemCizim();
        Sekil daire = new Daire(kalemCizimAPI);
        daire.ciz();




        // Composite Tasarım Deseni
        Komponent circle1 = new Circle();
        Komponent circle2 = new Circle();
        GrupKomponent grupKomponent = new GrupKomponent();
        grupKomponent.ekle(circle1);
        grupKomponent.ekle(circle2);
        grupKomponent.ciz();




        // Decorator Tasarım Deseni
        Kahve espresso = new Espresso();
        Kahve sutluEspresso = new SutEklentisi(espresso);
        System.out.println("Kahve fiyatı: " + espresso.fiyat());
        System.out.println("Sütlü Kahve fiyatı: " + sutluEspresso.fiyat());



        /*
        // Facade Tasarım Deseni
        Bilgisayar bilgisayar = new Bilgisayar();
        bilgisayar.baslat();


         */
        /*
        // Flyweight Tasarım Deseni
        KarakterFabrikasi karakterFabrikasi = new KarakterFabrikasi();
        Karakter karakter1 = karakterFabrikasi.getKarakter('A');
        Karakter karakter2 = karakterFabrikasi.getKarakter('B');
        karakter1.ciz(12);
        karakter2.ciz(24);


         */
        /*
        // Proxy Tasarım Deseni
        ResimProxy resimProxy = new ResimProxy("ornek.jpg");
        resimProxy.goster();


         */

    }
}

// ADAPTER Design Pattern
class EskiUSB {
    void baglan() {
        System.out.println("Eski USB cihazı bağlandı.");
    }
}

// Target
interface YeniUSB {
    void baglantiKur();
}

// Adapter
class USBAdapter implements YeniUSB {
    EskiUSB eskiUSB;

    public USBAdapter(EskiUSB eskiUSB) {
        this.eskiUSB = eskiUSB;
    }

    @Override
    public void baglantiKur() {
        eskiUSB.baglan();
    }
}



//-----------------------------------------------------------------------


// BRIDGE Design Pattern

interface CizimAPI {
    void ciz();
}

// Somut Cizim API
class KalemCizim implements CizimAPI {
    @Override
    public void ciz() {
        System.out.println("Kalem ile çizildi.");
    }
}

// Şekil Soyutlaması
abstract class Sekil {
     public CizimAPI cizimAPI;

    Sekil(CizimAPI cizimAPI) {
        this.cizimAPI = cizimAPI;
    }

    abstract void ciz();
}

// Sekil Uygulamaları
class Daire extends Sekil {
    public Daire(CizimAPI cizimAPI) {
        super(cizimAPI);
    }

    @Override
    void ciz() {
        System.out.print("Daire çiziliyor. ");
        cizimAPI.ciz();
    }
}

// -----------------------------------------------------------------------

// COMPOSITE Design Pattern

// Component
abstract class Komponent {
    abstract void ciz();
}

// Leaf
class Circle extends Komponent {
    @Override
    void ciz() {
        System.out.println("Circle çizildi.");
    }
}

// Composite
class GrupKomponent extends Komponent {
    private List<Komponent> komponentList = new ArrayList<>();

    void ekle(Komponent komponent) {
        komponentList.add(komponent);
    }

    @Override
    void ciz() {
        for (Komponent komponent : komponentList) {
            komponent.ciz();
        }
    }
}

// -----------------------------------------------------------------------

// DECERATOR Design Pattern


// Temel Kahve
interface Kahve {
    double fiyat();
}

// Espresso
class Espresso implements Kahve {
    @Override
    public double fiyat() {
        return 4.0;
    }
}

// Decorator
abstract class KahveDecorator implements Kahve {
    protected Kahve kahve;

    KahveDecorator(Kahve kahve) {
        this.kahve = kahve;
    }

    public double fiyat() {
        return kahve.fiyat();
    }
}

// Süt Eklentisi COMPONENT
class SutEklentisi extends KahveDecorator {
    SutEklentisi(Kahve kahve) {
        super(kahve);
    }

    public double fiyat() {
        return super.fiyat() + 1.0;
    }
}


// -----------------------------------------------------------------------

// FACEDE Design Pattern



// Subsystem 1
class CPU {
    void calistir() {
        System.out.println("CPU çalışıyor.");
    }
}

// Subsystem 2
class RAM {
    void yukle() {
        System.out.println("RAM yükleniyor.");
    }
}

// Subsystem 3
class HDD {
    void oku() {
        System.out.println("HDD okunuyor.");
    }
}

// Facade
class Bilgisayar {
    private CPU cpu;
    private RAM ram;
    private HDD hdd;

    public Bilgisayar() {
        cpu = new CPU();
        ram = new RAM();
        hdd = new HDD();
    }

    void baslat() {
        System.out.println("Bilgisayar başlatılıyor...");
        cpu.calistir();
        ram.yukle();
        hdd.oku();
        System.out.println("Bilgisayar başlatıldı.");
    }
}



// -----------------------------------------------------------------------

// FLYWEIGHT Design Pattern


// Flyweight
class Karakter {
    private char harf;

    public Karakter(char harf) {
        this.harf = harf;
    }

    public void ciz(int boyut) {
        System.out.println(harf + " boyut " + boyut);
    }
}

// Flyweight Factory
class KarakterFabrikasi {
    private Map<Character, Karakter> karakterler = new HashMap<>();

    public Karakter getKarakter(char harf) {
        if (!karakterler.containsKey(harf)) {
            karakterler.put(harf, new Karakter(harf));
        }
        return karakterler.get(harf);
    }
}


// -----------------------------------------------------------------------


// PROXY Design Pattern


// Subject
interface Resim {
    void goster();
}

// Real Subject
class GercekResim implements Resim {
    private String dosyaAdi;

    public GercekResim(String dosyaAdi) {
        this.dosyaAdi = dosyaAdi;
        yukle();
    }

    private void yukle() {
        System.out.println("Resim yükleniyor: " + dosyaAdi);
    }

    @Override
    public void goster() {
        System.out.println("Resim gösteriliyor: " + dosyaAdi);
    }
}

// Proxy
class ResimProxy implements Resim {
    private String dosyaAdi;
    private GercekResim gercekResim;

    public ResimProxy(String dosyaAdi) {
        this.dosyaAdi = dosyaAdi;
    }

    @Override
    public void goster() {
        if (gercekResim == null) {
            gercekResim = new GercekResim(dosyaAdi);
        }
        gercekResim.goster();
    }
}








