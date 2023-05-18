using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment12May
{
    internal class GenericDelegate
    {
        Action<string, double, int> GenDeligate = new Action<string, double, int>(CallFunctionA);

        
        public static void CallFunctionA(string Mail, double PhoneBill, int Calls)
        {
            Console.WriteLine(Mail);
            Console.WriteLine(PhoneBill);
            Console.WriteLine(Calls);
        }
        

    }
}
