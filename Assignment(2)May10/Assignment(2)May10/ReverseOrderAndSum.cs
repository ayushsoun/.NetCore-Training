using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_May10
{
    internal class ReverseOrderAndSum
    {
        public void getReverseOrder()
        {
            Console.WriteLine("Enter the number of elements you want to store in an array-: ");
            var numOfElements = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[numOfElements];

            for (var i=0;  i<numOfElements; i++)
            {
                Console.WriteLine("Element-{0} = ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            //arr.ToString();
            Console.WriteLine("The values stored in array are -: ");
            foreach(var i in arr)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Reverse of this array is -: ");
            for (var j = arr.Length; j > 0; j--)
            {
                Console.WriteLine("{0}", j);
            }

            //SUM Of Array
            var sum = 0;
            for(var i= 0; i<arr.Length; i++)
            {
                sum += arr[i];
            }

            Console.WriteLine("Sum of all the elements stored in the array is-:" + sum);
        }
    }
}
