using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment12May
{
    internal class Calculator
    {
        //deligate
        

        public void Menu()
        {
            Console.WriteLine("Select an arithmatic operation");
            Console.WriteLine("1)Addition");
            Console.WriteLine("2)Subtraction");
            Console.WriteLine("3)Multiplication");
            Console.WriteLine("4)Division");
            Console.WriteLine("5)Remainder");
            Console.WriteLine("6)Quit");
        }

        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Divide(double a, double b)
        {
            return a / b;
        }

        public double Modulus(double a, double b)
        {
            return a % b;
        }
    }
}
