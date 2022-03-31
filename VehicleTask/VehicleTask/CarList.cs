using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleTask
{
    class CarList
    {
        private Car[] Car;
        
        public CarList()
        {
            Car = new Car[0];
        }
        public Car[] GetCar()
        {
            return Car;
        }
        public Car[] Add(Car car)
        {
            Array.Resize(ref Car, Car.Length + 1);
            Car[Car.Length - 1] = car;
            return Car;
        }
    }
}
