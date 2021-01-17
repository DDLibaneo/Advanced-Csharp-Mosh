using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var calculator = new Calculator();
                var result = calculator.Divide(5, 0);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("You cannot divide by zero.");
            }
            catch(ArithmeticException ex)
            {
                Console.WriteLine("An arithmetic error occurred.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Sorry, an unexpected error occurred.");
            }
            finally // Usado geralmente pra fazer Dispose. 
            {
                // Exemplos: Conexões de banco, File handlers, network collections, 
                // graphic handlers.

                // Qualquer classe que usa recursos que não são gerenciadas pelo Garbage 
                // Collection é esperado que tenha uma implementação da interface IDisposable
            }

            // stack trace é a sequencia de métodos chamados até chegar no disparo da exception.

            Console.WriteLine("\nPress a key to close...");
            Console.ReadKey();
        }
    }
}
