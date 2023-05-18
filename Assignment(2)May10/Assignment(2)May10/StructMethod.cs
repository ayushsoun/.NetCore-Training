using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_May10
{

    struct Rectangle
    {
        private int _lenght { get; set; }
        private int _breadth { get; set; }
        private int _area { get; set; }
        private int _perimeter { get; set; }

        public void CalculateRectangle()
        {
            var rectangle = new Rectangle();
            Console.WriteLine("Enter lenght of rectangle-: ");
            _lenght = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter breadth of rectangle-: ");
            _breadth = Convert.ToInt32(Console.ReadLine());
            _area = _lenght * _breadth;
            Console.WriteLine("Area of given rectangle is -: {0}", _area);
            _perimeter = 2 * (_lenght + _breadth);
            Console.WriteLine("Perimeter of given rectangle is -: {0}", _perimeter);

        }
    };

}
