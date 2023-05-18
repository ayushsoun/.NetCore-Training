using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8May
{
    internal class MathOpreations
    {
        public void add()
        {
            Console.WriteLine("Enter first number");
            var a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second number");
            var b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine( a + b);
        }
        public void sub()
        {
            Console.WriteLine("Enter first number");
            var a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second number");
            var b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(a - b); 
        }
        public void multiply()
        {
            Console.WriteLine("Enter first number");
            var a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second number");
            var b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(a * b) ;
        }
        public void divide()
        {
            Console.WriteLine("Enter first number");
            var a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second number");
            var b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(a / b);
        }
    }
}
