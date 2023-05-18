using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8May
{
    internal class Swap
    {
        public void SwapTwoNumbers() 
        {
            Console.WriteLine("Enter first number");
            var a = Convert.ToInt32(Console.ReadLine);

            Console.WriteLine("Enter second number");
            var b = Convert.ToInt32(Console.ReadLine);

            var temp = a;
            a= b;
            b= temp;

            Console.WriteLine( "Swap values are-: ");
            Console.WriteLine("a = " + a );
            Console.WriteLine("b = " +  b );
        }
    }
}
