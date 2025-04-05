using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1{
    internal class Info
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Please enter your student ID: ");
            string id = Console.ReadLine();
            Console.Write("Please enter your CGPA: ");
            double cgpa = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n\n");

            Console.WriteLine(name + ", ID: " + id);
            Console.WriteLine("has CGPA: " + cgpa);

            Console.WriteLine("\n\n");
        }
    }
}
