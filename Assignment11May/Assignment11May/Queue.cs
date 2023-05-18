using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11May
{
    internal class Queue
    {
        public void CreateQueue()
        {
            Queue<int> bookRental = new Queue<int>();

            bookRental.Enqueue(1);

            bookRental.Enqueue(2);

            bookRental.Enqueue(3);

            bookRental.Enqueue(4);

            foreach (var item in bookRental)
            {
                Console.WriteLine(item);
            }
        }
    }
}
