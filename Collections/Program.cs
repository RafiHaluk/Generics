using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "Haluk", "Cansel", "Berkay", "Kerem" };
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);
            Console.WriteLine(names[3]);
            //arrayler oluşturulduğu sınırlarda çalışır 
            //names[5] = "Seda"; **** //yaparsak ve CW ile kontrol etmeye kalkarsak çalışmaycaktır çünkü bu bir static array
            names = new string[5];
            names[4] = "Berk";
            Console.WriteLine(names[4]);
            //yazarsak eğer "berk" yeni bir array oluşturulup arraye eklenir,
            //çünkü new dediğimiz için bellekteki eski names arayini patlatıp yeni bir names arrayi oluşturduk.
            //yani önceki "names" arrayi patladı. yani eğer şöyle yazarsak...
            Console.WriteLine(names[0]);//   "haluk" ismi gelmeyecektir, çünkü o eleman önceki names arrayinde kaldı...

            //*********Farklı Bİr Teknik Olarak "Collections" Yani ListArray Kullanımı****************
            Console.WriteLine("*******************");
            List<string> names2 = new List<string> { "Haluk", "Cansel", "Berk", "Merve" };
            Console.WriteLine(names2[0]);
            Console.WriteLine(names2[1]);
            Console.WriteLine(names2[2]);
            Console.WriteLine(names2[3]);
            names2.Add("Çokay");
            Console.WriteLine(names2[4]);
            Console.WriteLine(names2[1]);

            Console.WriteLine("********************");
            
            //sınıflar açık-yeşil renk ile yazılır

        }
    }
}
