using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    internal class Program
    {
        private string[] studentName = new string[20];

        public string this[int index]
        {
            get
            {  
                return studentName[index];
            }
            set
            {
                studentName[index] = value;
            }
        }
        static void Main(string[] args)
        {
            Program obj = new Program();

            obj[0] = "MD. Nazmus Sadat Numan.";
            obj[1] = "Sadat Numan.";
            obj[2] = "Nazmus Numan.";

            Console.WriteLine("First element in obj: " + obj[0]);
            Console.WriteLine("Second element in obj: " + obj[1]);
        }
    }
}