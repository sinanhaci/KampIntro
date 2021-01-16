using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2 };

            foreach (Urun urun in urunler)              //in urunler = urunler dizisinin her elemanını tek tek gez.
                                                        // Urun  = Veri tipi(var gibi) ,, urun = takma isim
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-----------------------");

            }

            Console.WriteLine("--------------Metotlar-----------------");

            //instance - metot örneği
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);


            sepetManager.Ekle2("Armut", "Yeşil Armut", 12, 10);
            sepetManager.Ekle2("Elma", "sarı Elma", 14, 10);
            sepetManager.Ekle2("Karpuz", "adana Karpuz", 16, 10);


        }
    }
}


//Metotlar tekrar tekrar kullanabilmemizi sağlan kod blokları