using Assignment9may;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Assignment 10-May");

        var calculator = new Calculator();
        calculator.CalculatorFn();

        var factorial = new Factorial();
        factorial.FactorialN();

        var palindrome = new Palindrome();
        palindrome.CheckPalindrome();

        var prime = new Prime();
        prime.FindPrime();

        var triangle = new Triangle();
        triangle.GetTriangle();
    }
}