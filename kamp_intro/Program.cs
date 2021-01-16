using System;

namespace kamp_intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Id = 1;
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Id = 2;
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] {urun1, urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Id);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("**********************");
            }

            Console.WriteLine("///////Metotlar///////");

            //ekle metotları arasındaki fark encapsulation dan geliyor
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("armut", "kış armutu", 12);
            sepetManager.Ekle2("elma", "amasya elması", 9);
            sepetManager.Ekle2("karpuz", "diyarbakır karpuzu", 65);
        
            //ürün için stok adedi eklemek istersek;
            //class a stok adedi özellik olarak eklenirse Ekle() metodu değişemeyecek
            //ama Ekle2() için iş zor olur, hem burada stokadetleri tek tek yazılmalıdırhemde metot da yeni bir parametre eklenmelidir.
            
        }
    }
}
