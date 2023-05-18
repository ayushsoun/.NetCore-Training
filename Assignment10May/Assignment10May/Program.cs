using Assignment10May;

internal class Program
{
    private static void Main(string[] args)
    {
        //#1
        var person = new Person();
        person.Greet();

        var student = new Student();
        student.SetAge(21);
        student.Greet();
        student.ShowAge();

        var teacher = new Teacher();
        teacher.SetAge(30);
        teacher.Greet();
        teacher.Explain();

        //#2
        var photoAlbum = new PhotoAlbum();
        photoAlbum.GetNumberOfPages();

        var photoAlbum2 = new PhotoAlbum(24);
        photoAlbum2.GetNumberOfPages();

        var bigPhotoAlbum = new BigPhotoAlbum();
        bigPhotoAlbum.GetNumberOfPages();

    }
}


