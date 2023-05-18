using Assignment12May;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using static Assignment12May.Calculator;

internal class Program
{
    public delegate double ArithmaticDelegate(double x, double y);
    private static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");

        var lambdaEx = new LambdaExpression();
        lambdaEx.OddEven();
        lambdaEx.SquareRoot();

        var calc = new Calculator();
        int operation;
        ArithmaticDelegate arithmatic;
        double x, y;

        do
        {
            Console.WriteLine("Enter two numbers seperated by Enter");
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            Console.Clear();

            calc.Menu();
            operation = int.Parse(Console.ReadLine());

            switch (operation)
            {
                //Addition
                case 1:
                    arithmatic = new ArithmaticDelegate(calc.Add);
                    break;
                //Subtraction
                case 2:
                    arithmatic = new ArithmaticDelegate(calc.Subtract);
                    break;
                //Multiplication
                case 3:
                    arithmatic = new ArithmaticDelegate(calc.Multiply);
                    break;
                //Division
                case 4:
                    arithmatic = new ArithmaticDelegate(calc.Divide);
                    break;
                //Remainder
                case 5:
                    arithmatic = new ArithmaticDelegate(calc.Modulus);
                    break;
                default:
                    Console.WriteLine("Exiting program");
                    break;
            }
            Console.Clear();
           // Console.WriteLine(arithmatic(x, y));
            Console.WriteLine("Press any key to continue");
            Console.ReadKey(true);
            Console.Clear();

        } while (operation != 6);


        //FoodOrder EventHandle

        var order = new Order() { Item = "Pizza" };

        var orderService = new FoodOrderingService();
        var appService = new AppService();

        //subscribe to the event by using the +=
        // here, we’re subscribing to the FoodPrepared event,
        // and using the OnFoodPrepared method of the AppService class to handle the event.
        orderService.FoodPrepared += appService.OnPreparedFood;
        orderService.PrepareOrder(order);


        //Serialize & Deserialize Employee data using binary formatter

        var employee = new Employee();
        employee.empId= 1;
        employee.empName= "Test";

        IFormatter formatter = new BinaryFormatter();
        Stream stream = new FileStream($"C:\\Users\\AR8TV94\\Documents\\learning\\.Net\\.netCore VWits\\Assignment12May\\12May.txt", FileMode.Create, FileAccess.Write);

        formatter.Serialize(stream, employee);
        stream.Close();

        stream = new FileStream($"C:\\Users\\AR8TV94\\Documents\\learning\\.Net\\.netCore VWits\\Assignment12May\\12May.txt", FileMode.Open, FileAccess.Read);

        Employee emp = (Employee)formatter.Deserialize(stream);
        Console.WriteLine(emp.empId);
        Console.WriteLine(emp.empName);



    }
}