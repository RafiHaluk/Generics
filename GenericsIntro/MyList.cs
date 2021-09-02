using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>///<----class tanımı tip yani....boolean, produıct clası,kredi clası,sepet clası....
    //yada herhangi bir değişken mesela T değişkeni eğer program.cs de bu mylsiti string olarak tanımlarsan arka planda bu T string olacak
   
    {
        T[] items;
        public MyList()
        {
         items = new T[0];
        }
        public void Add(T item) 
        {
            
            T[] tempArray = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i]; 
            }
            items[items.Length - 1] = item;
           
        }
        public int Length
        {
            get { return items.Length; }
        }
        public T[] Items
        {
            get { return items; }
        }
    }
}
