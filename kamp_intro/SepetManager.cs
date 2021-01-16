using System;
using System.Collections.Generic;
using System.Text;

namespace kamp_intro
{
    class SepetManager
    {
        //naming convention - isimlendirmede büyük harafle başlama gibi
        //Urun tipinde urun değişkeni oluşturduk
        //urun değişkeni metot içerisinde kullanılacak isimle 
        public void Ekle(Urun urun)   
        {
            Console.WriteLine("Tebrikler...Sepete Eklendi : " + urun.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat)
        {
            Console.WriteLine()
        }
    }
}
