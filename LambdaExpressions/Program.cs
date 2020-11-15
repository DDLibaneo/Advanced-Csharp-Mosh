using System;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstExample();


        }

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

            Console.WriteLine("Press a key to close...");
            Console.ReadKey();
        }

        static int SquareNonLambda(int number)
        {
            return number * number;
        }
    }
}
