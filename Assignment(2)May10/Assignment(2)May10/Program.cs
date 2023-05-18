using Assignment_2_May10;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        var reverseOrderAndSum = new ReverseOrderAndSum();
        reverseOrderAndSum.getReverseOrder();

        var structure = new Rectangle();
        structure.CalculateRectangle();

        var radiation = new RadiationEnum();
        radiation.RadiationLevel();

        var overloadmethod = new MethodOverloading();
        overloadmethod.MethodAdd(1, 2);
        overloadmethod.MethodString("abc");
    }
}


