using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment12May
{
    internal class AppService
    {
        //Subscribe to an Event
        public void OnPreparedFood(object source, EventArgs eventArgs) 
        {
            Console.WriteLine("AppService: Food is Prepared");
        }
    }
}
