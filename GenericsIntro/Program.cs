using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>(); // class tanımındaki T : string oldu
            isimler.Add("Şerife");
            Console.WriteLine(isimler.Length);   //elaman sayısı

            isimler.Add("Eren");
            Console.WriteLine(isimler.Length);

            //elemanları yazdırma
            foreach (var item in isimler.Items)   
            {
                Console.WriteLine(item);
            }
        }
    }
}
