using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11May
{
    internal class SortedClass
    {
        public void SortedBook()
        {
            SortedList<int, string> mySortedList = new SortedList<int, string>();


            mySortedList.Add(1, "BookA");
            mySortedList.Add(6, "BookB");
            mySortedList.Add(5, "BookC");
            mySortedList.Add(3, "BookD");

            Console.WriteLine("Before adding key value pair-------------------");

            foreach (KeyValuePair<int, string> i in mySortedList)
            {
                Console.WriteLine("key: {0}, value: {1}", i.Key, i.Value);
            }
            mySortedList.Add(4, "BookCd");
            mySortedList.Add(2, "BookDd");

            //The SortedList rearranges key-value pairs in the ascending order of keys
            //as soon as a key-value pair added.
            //The following example displays all the keys and values using foreach loop. 

            Console.WriteLine("After adding key value pair-------------------");

            foreach(var i in mySortedList)
            {
                Console.WriteLine("key: {0}, value: {1}", i.Key, i.Value);
            }
        }
    }
}
