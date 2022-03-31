using System;

namespace VehicleTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //Drive metoduna aid olan,və onu yoxlayan şərt.

            //Console.WriteLine("Enter km which drive: ");
            //double km = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter current fuel: ");
            //double CurrentFuel = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter fuel for one km: ");
            //double FuelFor1km = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter car millage: ");
            //double Millage = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter bycle millage: ");
            //double milage = double.Parse(Console.ReadLine());

            //Car vehicle = new Car(1000, CurrentFuel, FuelFor1km,Millage);
            //vehicle.Drive(km);
            //Console.WriteLine("There are liters of gasoline left: " + vehicle.CurrentFuel + "L");
            //Console.WriteLine("Millage: " + vehicle.Millage +"km");


            //Bycle bycucyle = new Bycle(milage);
            //bycucyle.Drive(km);
            //Console.WriteLine(bycucyle.Millage);

            //Array hissəsi.

            Console.WriteLine("Enter car count");
            int count = int.Parse(Console.ReadLine());

            for(int i = 0; i < count; i++)
            {
                Console.WriteLine("Enter data about car");
                Console.Write("fuel capacity car: ");
                double fuelCapacity = double.Parse(Console.ReadLine());
                Console.Write("Enter current fuel: ");
                double currentFuel = double.Parse(Console.ReadLine());
                Console.Write("Enter fuel for one killometr: ");
                double fuelFor1km = double.Parse(Console.ReadLine());
                Console.Write("Enter millage: ");
                double millage = double.Parse(Console.ReadLine());
                Console.WriteLine("Color car");
                string Color = Console.ReadLine();
                Console.WriteLine("Car Brand: ");
                string Brand = Console.ReadLine();
                


                Car car = new Car(fuelCapacity, currentFuel, fuelFor1km, millage,Color,Brand);
                CarList carList = new CarList();
                Console.WriteLine(carList.Add(car));
                foreach(var item in carList.GetCar())
                {
                    Console.WriteLine(item);
                }
                break;

            }
        }
    }
}
