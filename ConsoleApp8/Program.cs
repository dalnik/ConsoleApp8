using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.Name = "Programming in C#";
            book.author = "Tishchenko";
            book.hapters = "";
            book.pages = 1000;

            Console.WriteLine(book.Name);
            Console.WriteLine(book.author);
            Console.WriteLine(book.hapters);
            Console.WriteLine(book.pages);

        }
    }
}
