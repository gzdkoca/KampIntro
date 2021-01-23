using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        //constructor --> ctor - tabx2
        public MyList()
        {
            items = new T[0];
        }

        public void Add(T item)  //yeni gelen eleman
        {
            T[] tempArray = items;
            items = new T[items.Length+1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;  // yeni gelen elemanı sona ekler.
        }
    }
}
