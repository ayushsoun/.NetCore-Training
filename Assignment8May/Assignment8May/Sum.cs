using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8May
{
    internal class Sum
    {
        public void Add()
        {
            Console.WriteLine("Enter first number");
            var a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second number");
            var b = Convert.ToInt32(Console.ReadLine());

            var sum = a + b;
            Console.WriteLine(sum);
        }
    }
}
