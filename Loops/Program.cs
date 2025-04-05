using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Using for loop:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\nUsing foreach loop:");
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("\nUsing while loop:");
            int j = 1;
            while (j <= 10)
            {
                Console.WriteLine(j);
                j++;
            }

            Console.WriteLine("\nUsing do-while loop:");
            int k = 1;
            do
            {
                Console.WriteLine(k);
                k++;
            } while (k <= 10);

            Console.WriteLine("\nProgram finished!");
        }
    }
}
