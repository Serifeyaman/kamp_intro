using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //dosyaya loglama için
    class FileLoggerService : ILogerService
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya loglandı");
        }
    }
}
