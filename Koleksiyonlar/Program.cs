using System;
using System.Collections.Generic; //koleksiyonları kullanabilmek için 
namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //array  //dizilerde tanımlanan boyutun üstüne çıkılmaz
            //diziler genişletilmez genişletilirse varolan değerleri kaybeder
            string[] isimler = new string[] {"Şerife", "Eren", "Ali", "Veli" };

            //yukarıdaki dizinin koleksiyondaki tanımı
            List<string> isimler2 = new List<string>() {"Şerife", "Eren", "Ali", "Veli" };
           
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            // eleman ekleme   // sonuna ekler
            isimler2.Add("Haydar");
            Console.WriteLine(isimler2[4]);
        }
    }
}
