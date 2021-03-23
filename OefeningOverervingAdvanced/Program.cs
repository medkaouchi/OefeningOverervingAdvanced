using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningOverervingAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            CoffeeTableBook coffetablebook1 = new CoffeeTableBook();
            coffetablebook1.ISBN = 1;
            coffetablebook1.Title = "Titel1";
            coffetablebook1.Author = "Author1";
            coffetablebook1.Price = 10;
            Console.WriteLine(coffetablebook1);

            TextBook textbook1 = new TextBook();
            textbook1.ISBN = 2;
            textbook1.Title = "Titel2";
            textbook1.Author = "Author2";
            textbook1.Price = 165;
            textbook1.GradeLevel = 2;
            Console.WriteLine(textbook1);

            CoffeeTableBook coffetablebook = new CoffeeTableBook();
            coffetablebook.ISBN = 1;
            coffetablebook.Title = "Titel1";
            coffetablebook.Author = "Author1";
            coffetablebook.Price = 35;

            TextBook textbook = new TextBook();
            textbook.ISBN = 2;
            textbook.Title = "Titel2";
            textbook.Author = "Author2";
            textbook.Price = 65;
            textbook.GradeLevel = 2;

            Book book = TelOp(coffetablebook,textbook);
            book.ISBN = 2;
            Console.WriteLine(coffetablebook);
            Console.WriteLine(textbook);
            Console.WriteLine(book);
            Console.WriteLine(book.Equals(textbook)); Console.WriteLine(book.Equals(coffetablebook));
            Console.ReadLine();
        }
        static Book TelOp(Book book1,Book book2)
        {
            Book book = new Book();
            book.Title = $"Omnibus van [{book1.Author}, {book2.Author}]";
            book.Price = (book1.Price + book2.Price) / 2;
            return book;
        }
    }
}
