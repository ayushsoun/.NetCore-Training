using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment12May
{
    internal class LambdaExpression
    {
        public void OddEven()
        {
            var inputList = new List<int>();
            Console.WriteLine("Enter number seprated by comma");
            var input = Console.ReadLine();
            inputList = input.Split(',').Select(int.Parse).ToList();

            List<int> even = inputList.FindAll(x => x % 2 == 0);
            Console.WriteLine("Even numbers are -: ");
            foreach (int i in even)
            {
                Console.WriteLine(i);
            }

            List<int> odd = inputList.FindAll(x => x % 2 != 0);
            Console.WriteLine("Odd numbers are-: ");
            foreach (int i in odd)
            {
                Console.WriteLine(i);
            }
        }

        public void SquareRoot()
        {
            Func<int, double> squareRoot = x => Math.Sqrt(x);
            Console.WriteLine("Enter the number to find its square root");
            var input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Square root of {0} is-: {1}", input, squareRoot(input));
        }


        
    }
}
