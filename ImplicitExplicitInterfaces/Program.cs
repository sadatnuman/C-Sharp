using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplicitExplicitInterfaces
{
    interface ITest
    {
        void TestMethod();
    }

    class ImplicitTestClass : ITest
    {
        // Implicit interface implementation
        public void TestMethod()
        {
            Console.WriteLine("Implicit Interface Implementation");
        }
    }

    class ExplicitTestClass : ITest
    {
        // Explicit interface implementation
        void ITest.TestMethod()
        {
            Console.WriteLine("Explicit Interface Implementation");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Implicit implementation
            ImplicitTestClass implicitObj = new ImplicitTestClass();
            implicitObj.TestMethod(); // Can call directly

            // Explicit implementation
            ITest explicitObj = new ExplicitTestClass(); // Must access through interface reference
            explicitObj.TestMethod();
        }
    }
}