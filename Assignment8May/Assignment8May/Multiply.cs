using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8May
{
    internal class Multiply
    {
        public void MultiplyThreeNumbers()
        {
            Console.WriteLine("Enter first number");
            var a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second number");
            var b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Third number");
            var c = Convert.ToInt32(Console.ReadLine());

            var result = a * b * c;
            Console.WriteLine(result);
        }
    }
}
