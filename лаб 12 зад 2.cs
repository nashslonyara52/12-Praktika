using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class ProgramConfig
    {
        public const string Version = "9.9";
        public const string Name = "Пупуня Папин";

        public static void Display()
        {
            Console.WriteLine($"Версия: {Version}");
            Console.WriteLine($"Разработчик: {Name}");
       
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            ProgramConfig.Display();

        }
    }

}
