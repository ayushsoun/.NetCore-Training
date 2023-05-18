using Assignment8May;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Assignment 8 May");

        var hello = new Hello();
        hello.WelcomeMessage();

        var sum = new Sum();
        sum.Add();

        var divide = new Divide();
        divide.Division();

        var oprations = new Oprations();
        oprations.Solution1();
        oprations.Solution2();
        oprations.Solution3();
        oprations.Solution4();

        var swap = new Swap();
        swap.SwapTwoNumbers();

        var multiply = new Multiply();
        multiply.MultiplyThreeNumbers();

        var mathOpration = new MathOpreations();
        mathOpration.add();
        mathOpration.sub();
        mathOpration.multiply();
        mathOpration.divide();

        var table = new Table();
        table.MultiplicationTable();

        var average = new Average();
        average.FindAverage();

        var ex10 = new Excercise10();
        ex10.RequiredOutputA();
        ex10.RequiredOutputB();

        var ex11 = new Excercise11();
        ex11.AverageAge();

        var ex12 = new Excercise12();
        ex12.RepeatNumber();

        var ex13 = new Excercise13();
        ex13.CreateRectangle();




    }
}