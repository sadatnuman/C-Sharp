using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClasses
{
    public partial class Record
    {
        private int h;
        private int w;
        public Record(int h, int w)
        {
            this.h = h;
            this.w = w;
        }
    }
    public partial class Record
    {
        public void PrintRecord()
        {
            Console.WriteLine("Height:" + h);
            Console.WriteLine("Weight:" + w);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Record myRecord = new Record(10, 15);
            myRecord.PrintRecord();
            Console.ReadLine();
        }
    }
}
