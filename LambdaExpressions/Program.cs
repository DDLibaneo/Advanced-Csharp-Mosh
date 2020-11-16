using System;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Example 1 - basic lambda examples");

            FirstExample();

            Console.WriteLine("\n---------------");
            Console.WriteLine("Example 2 - on predicates");            

            SecondExample();

            Console.WriteLine("Press a key to close...");
            Console.ReadKey();
        }

        // Exemplo 1
        private static void FirstExample()
        {
            // The syntax for lambda works like this: arguments => expression
            // Read that as in: 'arguments goes to expression'
            // Example: number => number * number
            // To use a lambda function we assign it to a delegate, like below

            Func<int, int> squareLambda = number => number * number;

            // Remember, normally you'd do it like this:
            // Func<int, int> square = Square;

            // Calling examples below:
            Console.WriteLine("Using lambda with arguments: " + squareLambda(5));

            Console.WriteLine("Calliing method normally: " + SquareNonLambda(5));

            // to make a lambda with a function that takes no arguments, you can 
            // do it like below:

            Action squareLambdaWithoutArguments = () => Console.WriteLine("Message displayed with parameterless function");

            squareLambdaWithoutArguments();

            // more examples:
            // without args: () => ...
            // with only 1 arg: x => ...
            // with multiple args: (x, y, z)
        }

        static int SquareNonLambda(int number)
        {
            return number * number;
        }

        // Exemplo 2
        private static void SecondExample()
        {
            var books = new BookRepository().GetBooks();

            // A Predicate is basically a delegate which points to a method that 
            // gets a Book (in this case) and returns a boolean value specifying 
            // if a given condition is satisfied

            // this is what I always did, but simplified. I finally understand 
            // lambda functions
            Console.WriteLine("Cheapest books by passing a normal function to the delegate");
            var cheapBooksNormalFunction = books.FindAll(IsCheaperThan10Dollars);

            foreach (var book in cheapBooksNormalFunction)
            {
                Console.WriteLine(book.Title);
            }

            Console.WriteLine("Cheapest books by passing a lambda function to the delegate");
            var cheapBooksLambda = books.FindAll(book => book.Price < 10);

            foreach (var book in cheapBooksLambda)
            {
                Console.WriteLine(book.Title);
            }
        }

        // example of a predicate function 
        static bool IsCheaperThan10Dollars(Book book)
        {
            return book.Price < 10;
        }
    }
}
