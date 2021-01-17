using System;
using System.IO;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {            
            Example1();

            Example2();

            Example3();

            Console.WriteLine("\nPress a key to close...");
            Console.ReadKey();
        }

        private static void Example1()
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
            catch (ArithmeticException ex)
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
        }

        private static void Example2()
        {
            StreamReader streamReader = null;

            try
            {
                streamReader = new StreamReader(@"D:\Livros\A_Nao_Violencia_Uma_historia_Domenico_Losurdo.pdf");
                var content = streamReader.ReadToEnd();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Sorry, an unexpected error occurred.");
            }
            finally
            {
                if (streamReader != null)
                    streamReader.Dispose();
            }
        }

        private static void Example3()
        {
            try
            {
                var filePath = @"D:\Livros\A_Nao_Violencia_Uma_historia_Domenico_Losurdo.pdf";

                using var streamReader = new StreamReader(filePath);

                var content = streamReader.ReadToEnd();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Sorry, an unexpected error occurred.");
            }
        }
    }    
}
