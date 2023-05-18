using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment15May
{
    internal class Student
    {
        public void CreateDirectory()
        {
            //string root = @"C:\Users\AR8TV94\Documents\learning\.Net\.netCore VWits\Assignment15May\Assignment15May";
            string subDir = @"C:\Users\AR8TV94\Documents\learning\.Net\.netCore VWits\Assignment15May\Assignment15May\Student\";

            //if (!Directory.Exists(root))
            //{
            //    Directory.CreateDirectory(root);
            //}

            if (!Directory.Exists(subDir))
            {
                Directory.CreateDirectory($"{subDir}");
            }

            Console.WriteLine("Enter the students name");
            var inputName = Console.ReadLine();

            Console.WriteLine("Enter student age");
            var age = Console.ReadLine();

            Console.WriteLine("Enter student's address");
            var address = Console.ReadLine();

            string file_name = subDir + inputName;
            try
            {
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(file_name))
                {
                    File.Delete(file_name);
                }
                //create a new file
                using (FileStream fs = File.Create(file_name))
                {
                    Byte[] name = new UTF8Encoding(true).GetBytes("Student's Name is-: " + inputName);
                    fs.Write(name, 0, name.Length);

                    Byte[] Sage = new UTF8Encoding(true).GetBytes("Student's age is -: " + age);
                    fs.Write(Sage, 0, Sage.Length);

                    Byte[] Saddress = new UTF8Encoding(true).GetBytes("Student's address is -: " + address);
                    fs.Write(Saddress, 0, Saddress.Length);
                }

                using (StreamReader sr = File.OpenText(file_name))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
