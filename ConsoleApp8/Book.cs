using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Book
    {
        //privat string name; // название  книги
        //int author, hapters, pages; // автор, главы, страницы

        public Book(string name, string author, string hapters, int pages)
        {
            this.name = name;
            this.author = author;
            this.hapters = hapters;
            this.pages = pages;
        }
        {
            public String Name { get => name; set => name = value; }
            public String Author { get =>author; set => author = value; }
            public String Hapters { get => hapters; set => hapters = value; }
            public int Pages { get => pages; set => pages = (value > 0 ? value : 1; }
        }
        public override string ToString()
        {
            return $ "Name: {name}, Autor: {autor}, Hapter: {hapter}, 
        }
    }
    }

        
       
    
}
