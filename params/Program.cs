using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params
{
    internal class Program
    {
        // function containing params parameters 
        public static int Add(params int[] ListNumbers)
        {
            int total = 0;

            // foreach loop 
            foreach (int i in ListNumbers)
            {
                total += i;
            }
            return total;
        }
        static void Main(string[] args)
        {
            // Calling function by passing 5 
            // arguments as follows 
            int y = Add(12, 13, 10, 15, 56);

            // Displaying result 
            Console.WriteLine(y);
        }
    }
}
