using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleTask
{
    class Bycle : Vehicle
    {
        public Bycle(double millage) : base(millage)
        {

        }
        public void Drive(double km)
        {
            Console.WriteLine("Millage bycle: ");
            Millage += km;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Color: {Color}, Brand: {Brand}, Millage: {Millage}");
        }
    }
}
