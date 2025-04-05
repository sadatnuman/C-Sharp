using System;

namespace Polymorphism
{
    // Base class: Shape
    class Shape
    {
        // Virtual method for drawing a shape, allowing overriding in derived classes
        public virtual void Draw()
        {
            Console.WriteLine("Shape drawn");
        }
    }

    // Derived class: Rectangle
    class Rectangle : Shape
    {
        // Override the Draw method to provide specific implementation for Rectangle
        public override void Draw()
        {
            Console.WriteLine("Rectangle Drawn");
        }
    }

    // Derived class: Circle
    class Circle : Shape
    {
        // Override the Draw method to provide specific implementation for Circle
        public override void Draw()
        {
            Console.WriteLine("Circle Drawn");
        }
    }

    // Derived class: Triangle
    class Triangle : Shape
    {
        // Override the Draw method to provide specific implementation for Triangle
        public override void Draw()
        {
            Console.WriteLine("Triangle Drawn");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Testing Polymorphism

            // Array of Shape references
            Shape[] shapes = new Shape[3];

            // Polymorphic Objects: Creating Array with different types of objects
            shapes[0] = new Circle();
            shapes[1] = new Rectangle();
            shapes[2] = new Triangle();

            Console.WriteLine("\n\nRuntime polymorphism test\n\n");

            // Loop through the array and call the Draw method
            // The method that gets called depends on the actual type of the object
            for (int i = 0; i < 3; i++)
            {
                shapes[i].Draw();
            }

            // Wait for user input before closing
            Console.ReadKey();
        }
    }
}
