using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleTask
{
    class Car : Vehicle
    {
        public double FuelCapacity;
        public double CurrentFuel;
        public double FuelFor1km;

        public Car(double fuelCapacity,double currentFuel,double fuelFor1km,double millage) : base(millage)
        {
            FuelCapacity = fuelCapacity;
            CurrentFuel = currentFuel;
            FuelFor1km = fuelFor1km;
        }
        public Car(double fuelCapacity, double currentFuel, double fuelFor1km, double millage,string color,string brand) : base
            (color,brand)
        {
            FuelCapacity = fuelCapacity;
            CurrentFuel = currentFuel;
            FuelFor1km = fuelFor1km;
        }
        public bool Drive(double km)
        {
            bool cheks = true;
            if(FuelFor1km * km > CurrentFuel)
            {
                Console.WriteLine("Not enough gasoline!");
                cheks = false;
            }
            if(FuelFor1km * km < CurrentFuel)
            {
                CurrentFuel -= FuelFor1km * km;
                Millage += km;
            }
            return cheks;
        }

        public void AllInfo()
        {
            Console.WriteLine($"Fuel capacity: {FuelCapacity}L\nCurrent fuel: {CurrentFuel}L\nFuel for one km: {FuelFor1km}L\n" +
                $"Millage: {Millage}km\nColor: {Color}\nBrand: {Brand}");
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Color: {Color}, Brand: {Brand}, Millage: {Millage}");
        }
    }
}
