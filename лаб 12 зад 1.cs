using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        internal class Calculator
        {
            public static double Add(double a, double b)
            {
                return a + b;
            }

            public static double Subtract(double a, double b)
            {
                return a - b;
            }

            public static double Multiply(double a, double b)
            {
                return a * b;
            }

            public static double Divide(double a, double b)
            {
                if (b == 0)
                {
                    Console.WriteLine("Ошибка: деление на ноль невозможно.");
                    return double.NaN;
                }
                return a / b;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("9 + 8 = " + Calculator.Add(9, 8));
            Console.WriteLine("7 - 6 = " + Calculator.Subtract(7, 6));
            Console.WriteLine("5 * 4 = " + Calculator.Multiply(5, 4));
            Console.WriteLine("3 / 2 = " + Calculator.Divide(3, 2));
            Console.WriteLine("3 / 0 = " + Calculator.Divide(3, 0));
        }
    }
    
}
