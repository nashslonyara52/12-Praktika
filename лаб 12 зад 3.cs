using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class ObjektCounter
    {
        private static int count = 0;

        public ObjektCounter()
        {
            count++;
        }
        public static void Display()
        {
            Console.WriteLine($"Создано объектов: {count} ");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            ObjektCounter.Display();

            ObjektCounter ob1 = new ObjektCounter();
            ObjektCounter.Display();

            ObjektCounter ob2 = new ObjektCounter();
            ObjektCounter ob3 = new ObjektCounter();
            ObjektCounter ob4 = new ObjektCounter();
            ObjektCounter.Display();
        }
    }
}
