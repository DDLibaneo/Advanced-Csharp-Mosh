using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace LINQ_Study
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            // This syntax is called "LINQ Extension methods"
            var cheapBooks = books
                .Where(b => b.Price < 10)
                .OrderBy(b => b.Title);

            Console.WriteLine("Exemplo 1\n");

            foreach (var book in cheapBooks)
                Console.WriteLine(book.Title + " $" + book.Price);

            Console.WriteLine("\nExemplo 2\n");

            // Sobre o Select()
            // Select é usado para projeções e transformações. P.e, se vc 
            // quisesse iterar uma lista de livros e para cada livro convertemos
            // para outro objeto, ou selecionar uma de suas propriedades como string.
            var cheapBooksTitles = cheapBooks.Select(b => b.Title);

            foreach (var title in cheapBooksTitles)
                Console.WriteLine(title);

            Console.WriteLine("\nExemplo 3\n");

            // LINQ Query Operators
            var cheapBooksQueryOperator = 
                from b in books
                where b.Price < 10
                orderby b.Title
                select b;

            foreach (var book in cheapBooksQueryOperator)
                Console.WriteLine(book.Title);

            Console.WriteLine("Press a key to close...");
            Console.ReadKey();
        }
    }
}
