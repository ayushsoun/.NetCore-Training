using static Assignment11May.BookShopNode<T>;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        DoublyBookList<int> dList = new DoublyBookList<int>();
        //Add nodes to the list  
        dList.AddBook(1);
        dList.AddBook(2);
        dList.AddBook(3);
        dList.AddBook(4);
        dList.AddBook(5);
        //Displays the nodes present in the list  
        dList.Display();
    }
}