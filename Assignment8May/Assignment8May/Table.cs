using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8May
{
    internal class Table
    {
        public void MultiplicationTable()
        {
            int result;
            Console.WriteLine("Enter a number");
            var num = Convert.ToInt32(Console.ReadLine());

            for(var i = 0; i <= 10; i++)
            {
                num *= i;
                result = num;
                Console.WriteLine(result);
            }
            
        }
    }
}
