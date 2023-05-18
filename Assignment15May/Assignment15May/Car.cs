using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment15May
{
    internal class Car
    {
        private int _carId;
        private string _carName;
        private string _carDescription;
        private string _carType;

        public Car(int id, string name, string description, string type) 
        { 
            _carId = id;
            _carName = name;
            _carDescription = description;
            _carType = type;
        }

        public void CarDisplay(Car car)
        {
            Console.WriteLine("Car is-: car id = {0}, car name = {1}, car description = {2}, car type = {3}", car._carId, car._carName, car._carDescription, car._carType);
            
        }
    }
}
