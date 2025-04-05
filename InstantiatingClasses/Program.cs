using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstantiatingClasses
{
    public class Car
    {
        private string make;
        private string model;
        private int year;

        public Car(string make, string model, int year)
        {
            this.make = make;
            this.model = model;
            this.year = year;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Car Details: {year} {make} {model}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the Car class using the constructor
            Car myCar = new Car("Toyota", "Corolla", 2020);

            // Call a method on the object
            myCar.DisplayDetails();

            // Instantiate another Car object
            Car anotherCar = new Car("Tesla", "Model 3", 2023);

            // Display details of the second car
            anotherCar.DisplayDetails();

            // Wait for user input before closing the console
            Console.ReadLine();
        }
    }
}
