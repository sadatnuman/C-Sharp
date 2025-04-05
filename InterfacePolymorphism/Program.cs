using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePolymorphism
{
    interface IAnimal
    {
        void AnimalSound(); // Interface method
    }

    // Pig class implements the IAnimal interface
    class Pig : IAnimal
    {
        public void AnimalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }

    // Dog class implements the IAnimal interface
    class Dog : IAnimal
    {
        public void AnimalSound()
        {
            Console.WriteLine("The dog says: woof woof");
        }
    }

    // Cat class implements the IAnimal interface
    class Cat : IAnimal
    {
        public void AnimalSound()
        {
            Console.WriteLine("The cat says: meow meow");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Using polymorphism
            IAnimal myPig = new Pig();  // Create a Pig object
            IAnimal myDog = new Dog();  // Create a Dog object
            IAnimal myCat = new Cat();  // Create a Cat object

            // Call the AnimalSound method on each object
            myPig.AnimalSound();
            myDog.AnimalSound();
            myCat.AnimalSound();
        }
    }
}
