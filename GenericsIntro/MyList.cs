using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    //generic class : çalışılacak tipi olan sınıf
    //T : sınıf nesnesi oluşunca hangi tip verileriyorsa odur
    class MyList<T>   
    {
        T[] items;
        //constructor : class dan bir nesne oluşturulduğu zaman otomatik çalışır
        public MyList()
        {
            items = new T[0];                 //Liste oluşunca 0 elemanlı dizi oluşacak
        }
        public void Add(T item)
        {
            T[] tempArray = items;            // geçici dizi  // referans numarası unutulmasın diye bir önceki eleman tutulur
            items = new T[items.Length + 1];  // dizinin eleman sayısını bir artır // mevcut eleman sayısını bir artır
            
            //tempArray deki elemanlar items a alınır
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item; // gelen eleman dizi sonuna eklenir
        }

        public int Length    //eleman sayısını verir
        {
            get { return items.Length; }
        }

        public T[] Items    //elemanları verir
        {
            get { return items; }
        }
    }
}
