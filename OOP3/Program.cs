using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //interface lerde interface edilen classın referansını tutabilir
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();

            IKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();

            IKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            //logalama alternatifleri
            ILogerService databaseLoggerService = new DatabaseLoggerService();
            ILogerService fileLoggerService = new FileLoggerService();

            //yukarıdaki hangi kredinin referansını gönderirsek ona göre hesaplar
            BasvuruManager basvuruManager = new BasvuruManager();
            //yukarıdaki refranslardan birini gönderilir, hangisi giderse onun hesaplası çalışır
            basvuruManager.BasvuruYap(ihtiyacKrediManager, new DatabaseLoggerService());

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager};
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}
