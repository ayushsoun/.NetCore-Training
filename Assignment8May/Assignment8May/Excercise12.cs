using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8May
{
    internal class Excercise12
    {
        public void RepeatNumber()
        {
            Console.WriteLine("Enter a Number ");
            var num = Convert.ToInt32(Console.ReadLine());
            for (var i = 0; i < 2; i++)
            {
                for (var j = 0; j < 4; i++)
                {
                    Console.WriteLine("{0}", num);
                }
                Console.WriteLine("{0}", num);
            }
        }
    }
}
