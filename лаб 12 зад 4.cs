using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Book
    {
        public readonly string ISBN;

        public string Title;

        public string Author;

        public Book(string isbn, string title, string author)
        {
            ISBN = isbn;     
            Title = title;   
            Author = author; 
        }

        public void Display()
        {
            Console.WriteLine("Информация о книге:");
            Console.WriteLine("ISBN: " + ISBN);
            Console.WriteLine("Название: " + Title);
            Console.WriteLine("Автор: " + Author);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Book myBook = new Book("123-456-789", "Колобок", "Народ");
            myBook.Display();

            myBook.Title = "Теремок";
            myBook.Display();

            myBook.Author = "Пуп земли";
            myBook.Display();

        }
    }
}
