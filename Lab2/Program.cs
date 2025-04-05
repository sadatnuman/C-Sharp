using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Calculation
    {
        public static void Main(string[] args)
        {
            double num1, num2;
            Console.Write("Enter two numbers: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the operator: ");
            char op = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("\n\n");

            double result;
            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    Console.WriteLine("Sum of two numbers is: " + result);
                    break;
                case '-':
                    result = num1 - num2;
                    Console.WriteLine("Sub of two numbers is: " + result);
                    break;
                case '*':
                    result = num1 * num2;
                    Console.WriteLine("Mult of two numbers is: " + result);
                    break;
                case '/':
                    result = num1 / num2;
                    Console.WriteLine("Div of two numbers is: " + result);
                    break;
                default:
                    Console.WriteLine("Invalid Operator!");
                    break;
            }

            /*if(op == '+'){
                result = num1 + num2;
                Console.WriteLine("Sum of two numbers is: " + result);
            }
            else if(op == '-'){
                result = num1 - num2;
                Console.WriteLine("Sub of two numbers is: " + result);
            }
            else if(op == '*'){
                result = num1 * num2;
                Console.WriteLine("Mult of two numbers is: " + result);
            }
            else if(op == '/'){
                result = num1 / num2;
                Console.WriteLine("Div of two numbers is: " + result);
            }
            else{
                Console.WriteLine("Invalid Operator!");
            }*/

            Console.WriteLine("\n\n");
        }
    }
}
