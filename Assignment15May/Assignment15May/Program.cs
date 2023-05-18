using Assignment15May;
using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Xml.Serialization;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        var car = new Car(1,"car", "xyz", "black");
        car.CarDisplay(car);

        //XMLSerialization

        var emp = new Employee()
        { 
            empid = 1,
            empname = "AbcEmp",
            salary = 100000

        };
        
        var xmlSerialization  = new XmlSerializer(typeof(Employee));

        using(var writer  = new StringWriter()) 
        {
            xmlSerialization.Serialize(writer, emp);
        }


        //JSON Serialization

        List<Books> book = new()
        {   new Books
            { 
                bookId = 1,
                bookName = "ABCBook",
                author = "xyzAuthor",
                genre = "all",
                price = 1000
            },
            new Books
            {
                bookId = 2,
                bookName = "ABook",
                author = "xAuthor",
                genre = "action",
                price = 200
            },
            new Books
            {
                bookId = 3,
                bookName = "BBook",
                author = "yAuthor",
                genre = "Rom",
                price = 800
            },
            new Books
            {
                bookId = 4,
                bookName = "XBook",
                author = "AAuthor",
                genre = "om",
                price = 700
            },
            new Books
            {
                bookId = 5,
                bookName = "CBook",
                author = "CAuthor",
                genre = "C.om",
                price = 80
            }
        };

        var jsonSerialization = JsonConvert.SerializeObject(book);
        Console.WriteLine(jsonSerialization);


        //create and add text in file
        var file = new CreateFile();
        file.Flie();


        //create Student task
        var student = new Student();
        student.CreateDirectory();

    }
}