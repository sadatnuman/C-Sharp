using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Vehicle
    {
        public string VehicleName;
        private string vehicleID;
        public static int vehicleCount = 0;

        public Vehicle()
        {
            vehicleCount++;
        }
        public string VehicleID
        {
            get { return vehicleID; }
            set { vehicleID = value; }
        }

        public virtual void Status()
        {
            Console.WriteLine("Vehicle is in good condition.");
        }

        public void ShowInfo()
        {
            Console.WriteLine("Vehicle Name: " + VehicleName + ", Vehicle ID: " + VehicleID);
        }
    }
    class Motorbike : Vehicle
    {
        public Motorbike()
        {
            VehicleName = "Motorbike";
        }
        public override void Status()
        {
            Console.WriteLine("Motorbike is ready to ride!");
        }
    }

    class Truck : Vehicle
    {
        public Truck()
        {
            VehicleName = "Truck";
        }
        public override void Status()
        {
            Console.WriteLine("Truck is loaded and ready for transport!");
        }
    }
    class Car : Vehicle
    {
        public Car()
        {
            VehicleName = "Car";
        }
        public override void Status()
        {
            Console.WriteLine("Car is ready for a drive!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle obj1 = new Motorbike();
            Vehicle obj2 = new Truck();
            Vehicle obj3 = new Car();

            obj1.VehicleID = "01";
            obj2.VehicleID = "02";
            obj3.VehicleID = "03";

            obj1.ShowInfo();
            obj2.ShowInfo();
            obj3.ShowInfo();
            Console.WriteLine("\n\n");


            Console.WriteLine("Polpolymorphism: ");
            obj1.Status();
            obj2.Status();
            obj3.Status();
            Console.WriteLine("\n\n");


            Console.WriteLine("Total Vehicles Created:" + Vehicle.vehicleCount);
            Console.WriteLine("\n\n");

        }
    }
}
