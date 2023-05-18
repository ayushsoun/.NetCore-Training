using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment16May
{
    internal class TestThread
    {
        public void TestTime()
        {
            Console.WriteLine("Stop");
            Thread.Sleep(1000);
            Console.WriteLine("Restart");
            Thread.Sleep(1000);
            Console.WriteLine("1....");
            Thread.Sleep(1000);
            Console.WriteLine("2....");
            Thread.Sleep(1000);
            Console.WriteLine("3....");
            Console.WriteLine("Started");
        }

        public void TestLoop()
        {
            Console.WriteLine("Let's loop here!");
            for (int i = 0; i < 20; i++)
                Console.Write($"{i} ");
            Console.WriteLine();
            Console.WriteLine("I'm done.");
        }

        
    }
}
