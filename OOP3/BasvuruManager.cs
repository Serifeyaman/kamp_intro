using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //method injection : bu metodun nereye etki edeceğini belirliyoruz
        public void BasvuruYap(IKrediManager krediManager,ILogerService loggerService)
        {
            //Başvuran bilgileri değerlendirme
            //Kredi hesaplama - aşağıdaki yanlış yol
            //aşağıdaki gibi hesaplanırsa tüm başvuruları konut kredisi hesaplamasına göre yapar
            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            //hangi krediyi gönderirsek ona göre hesapla çalışır.
            krediManager.Hesapla();
            loggerService.Log();
        }

        //kaçta olduğu belli olmayan birden fazla kredi için hesaplama yapacak
        //List yapısı kullanılarak krediler parametre olarak verilir
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
