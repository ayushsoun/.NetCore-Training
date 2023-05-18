using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment16May
{
    internal class DoWeightLifting
    {
        private int _minWeight;
        public void MinimumWeight() 
        {
            _minWeight = 20;
            WeightLifting(_minWeight);
        }
        public void WeightLifting(int weight)
        {
            Console.WriteLine("I am lifting {0}kg of weight ", weight);
        }
    }
}
