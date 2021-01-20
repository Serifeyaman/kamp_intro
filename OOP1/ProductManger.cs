using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManger
    {
        //operasyonları tutan sınıf
        public void Add(Product product)     //ürün ekleme - Product türünde parametre alır
        {
            Console.WriteLine(product.ProductName + " eklendi!!!");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi!!!");
        }   
    }
}
