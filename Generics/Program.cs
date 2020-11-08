using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book { Isbn = "1111", Title = "C# Advanced" };

            //Trocamos esses dois por uma lista de Genericos
            //var numbers = new List();
            //numbers.Add(10);

            //var books = new Booklist();
            //books.Add(book);

            var numbers = new GenericList<int>();
            numbers.Add(10);

            var books = new GenericList<Book>();
            books.Add(new Book());

            //Genericos em .NET são encontrados nas classes da 'System.Collections.Generic'

            Console.WriteLine("Press a key to close...");
            Console.ReadKey();
        }
    }
}
