using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_May10
{
    internal class RadiationEnum
    {
        public void RadiationLevel()
        {
            Console.WriteLine("Enter ration level in thousands value i.e. 1000, 2000....");
            var value = Convert.ToInt32(Console.ReadLine());

            if(value > 5000 ) 
            {
                Console.WriteLine(Level.High);
            }else if(value >2500 &&  value < 4000)
            {
                Console.WriteLine(Level.Medium);
            }else if(value < 2000)
            {
                Console.WriteLine(Level.Low);
            }
        }
    }

    public enum Level
    {
        Low, 
        Medium, 
        High
    }
}
