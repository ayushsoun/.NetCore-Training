using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9may
{
    internal class Triangle
    {

        public void GetTriangle()
        {
            char ch = 'A';
            int i, j, k, m;
            for (var i = 1; i <= 5; i++)
            {
                for (j = 5; j >= i; j--)
                    Console.Write(" ");
                for (k = 1; k <= i; k++)
                    Console.Write(ch++);
                ch--;
                for (m = 1; m < i; m++)
                    Console.Write(--ch);
                Console.Write("\n");
                ch = 'A';
            }
        }
    }
}
