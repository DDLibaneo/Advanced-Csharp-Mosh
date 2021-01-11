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

            Console.WriteLine("Exemplo 1: Linq basico\n");

            foreach (var book in cheapBooks)
                Console.WriteLine(book.Title + " $" + book.Price);

            Console.WriteLine("\nExemplo 2: Metodo de extensao Linq Select()\n");

            // Sobre o Select()
            // Select é usado para projeções e transformações. P.e, se vc 
            // quisesse iterar uma lista de livros e para cada livro convertemos
            // para outro objeto, ou selecionar uma de suas propriedades como string.
            var cheapBooksTitles = cheapBooks.Select(b => b.Title);

            foreach (var title in cheapBooksTitles)
                Console.WriteLine(title);

            Console.WriteLine("\nExemplo 3: Linq com Query Operators (from, where, select, etc)\n");

            // LINQ Query Operators
            var cheapBooksQueryOperator = 
                from b in books
                where b.Price < 10
                orderby b.Title
                select b;

            foreach (var book in cheapBooksQueryOperator)
                Console.WriteLine(book.Title);

            Console.WriteLine("\nExemplo 4: Metodos de extensao Linq interessantes");
            Console.WriteLine("Paginacao\n");
            // Exemplos de métodos de extensão Linq interessantes
            // Paginação
            var pagedBooks = books
                .Skip(2)
                .Take(3);
            
            foreach (var book in pagedBooks)
                Console.WriteLine(book.Title + " - $" + book.Price);

            Console.WriteLine("\nSoma\n");
            // Soma
            var somaPrecos = books.Sum(b => b.Price);

            Console.WriteLine("Preço total dos livros: " + somaPrecos);

            Console.WriteLine("Press a key to close...");
            Console.ReadKey();
        }
    }
}
