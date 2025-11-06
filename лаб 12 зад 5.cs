using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Settings
    {
        private static readonly string configur;

        static Settings()
        {
            configur = @"dlnv\gal\conlzjxnhsig.txt"; 
        }

        public static void Display()
        {
            Console.WriteLine("Путь к файлу конфигурации: " + configur);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Settings.Display();

            Console.ReadLine();
        }
    }
}
