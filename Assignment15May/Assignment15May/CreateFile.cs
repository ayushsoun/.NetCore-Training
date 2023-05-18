using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment15May
{
    internal class CreateFile
    {
        public void Flie() {
            string file_name = @"C:\Users\AR8TV94\Documents\learning\.Net\.netCore VWits\Assignment15May\mytest.txt";

            try
            {
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(file_name))
                {
                    File.Delete(file_name);
                }
                //create a new file
                using(FileStream fs = File.Create(file_name))
                {
                    Byte[] greet = new UTF8Encoding(true).GetBytes("Hello and Welcome");
                    fs.Write(greet, 0, greet.Length);

                    Byte[] description = new UTF8Encoding(true).GetBytes("It is the first content of the text file mytext.txt");
                    fs.Write(description, 0, description.Length);
                }

                // Open the stream and read it back.    
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
