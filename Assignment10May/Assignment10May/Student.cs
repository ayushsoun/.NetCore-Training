using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment10May
{
    internal class Student : Person
    {
        public void ShowAge()
        {
            Console.WriteLine("My age is: {0} years old", age);
        }
        public void GoToClasses()
        {
            Console.WriteLine("I am going to classes");
        }
    }
}
