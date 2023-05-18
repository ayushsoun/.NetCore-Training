using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11May
{
    internal class SortListAsc
    {
        public void AsceList()
        {
            List<int> list = new List<int>();
            list.Add(3);
            list.Add(4);
            list.Add(6);
            list.Add(2);
            list.Add(1);

            Console.WriteLine("List Before Sort");

            foreach(int i in list)
            {
                Console.WriteLine(i);
            }

            list.Sort();

            Console.WriteLine("List after Sort");

            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
        }

        public void HashTable() 
        {
            Hashtable bookShop = new Hashtable();

            bookShop.Add(1, "BOne"); //adding a key/value using the Add() method
            bookShop.Add(2, "BTwo");
            bookShop.Add(3, "BThree");

            foreach(DictionaryEntry entry in bookShop)
            {
                Console.WriteLine("BookId: {0}, BookName: {1}", entry.Key, entry.Value);
            }

        }
    }
}
