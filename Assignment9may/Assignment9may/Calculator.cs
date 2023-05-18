using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9may
{
    internal class Calculator
    {
        public void CalculatorFn()
        {

                float result = 0;
                //Getting Input of First number
                Console.WriteLine("Enter first number");
                float num1 = float.Parse(Console.ReadLine());

                //Getting Input of second number
                Console.WriteLine("Enter second number");
                float num2 = float.Parse(Console.ReadLine());

                //Getting the math operator
                Console.WriteLine("Enter operator");
                string op = Console.ReadLine();

                switch (op)
                {

                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        result = num1 / num2;
                        break;
                    case "%":
                        result = num1 % num2;
                        break;



                }
                Console.WriteLine("Result = " + result);


        }
    }
    
}
    

