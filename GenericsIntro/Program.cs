﻿using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> names = new MyList<string>();
            names.Add("Haluk");
            Console.WriteLine(names.Length);
            
            names.Add("Cansel");
            Console.WriteLine(names.Length);
            foreach (var item in names.Items)
            {
                Console.WriteLine(item);
            }
           
        }
    }
}
