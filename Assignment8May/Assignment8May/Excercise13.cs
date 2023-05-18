using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8May
{
    internal class Excercise13
    {
        public void CreateRectangle()
        {
            Console.Write("Enter a number: ");
            var x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}{0}{0}", x);
            Console.WriteLine("{0} {0}", x);
            Console.WriteLine("{0} {0}", x);
            Console.WriteLine("{0} {0}", x);
            Console.WriteLine("{0}{0}{0}", x);
        }
    }
}
