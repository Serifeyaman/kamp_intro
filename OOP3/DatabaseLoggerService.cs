using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //veritabanına loglama yaptırmak için
    class DatabaseLoggerService : ILogerService
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına loglandı");
        }
    }

}
