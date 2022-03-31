using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleTask
{
    class Vehicle
    {
        public string Color;
        public string Brand;
        public double Millage;

        public Vehicle(double millage)
        {
            Millage = millage;
        }
        public Vehicle(string color,string brand)
        {
            Color = color;
            Brand = brand;
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine($"Color: {Color}, Brand: {Brand}, Millage: {Millage}");
        }
    }
}
