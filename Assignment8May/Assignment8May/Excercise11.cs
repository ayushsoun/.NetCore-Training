using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8May
{
    internal class Excercise11
    {
        public void AverageAge()
        {
            Console.WriteLine("Enter your Age ");
            var age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("You look older than {0}", age);
        }
    }
}
