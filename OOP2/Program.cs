using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Şerife Yaman
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Şerife";
            musteri1.Soyadi = "Yaman";
            musteri1.TcNo = "12345678910";

            //Kodlama.io
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri1.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "12345678920";

            //musteri hem gercek hemde tuzel musterinin adresini tutabiliyor
            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            //Ekle metodu Musteri türünde parametre alıyor.
            //GercekMUsteri ve TuzelMusteri sınıfları, Musteriden miras aldığı için bu sınıfların nesneleride kullanılabilir.
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);


        }
    }
}
