using System;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exemplo 1: Metodos basicos dos tipos nullable\n");

            DateTime? date = null;

            Console.WriteLine("GetValueOrDefault(): " + date.GetValueOrDefault());
            Console.WriteLine("HasValue: " + date.HasValue);

            try
            {
                Console.WriteLine("Value: " + date.Value);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); 
            }

            Console.WriteLine("\nExemplo 2: Use o GetValueOrDefault() quando precisar atribuir o valor de uma variavel com tipo nullable para uma com tipo normal\n");

            DateTime? date2 = new DateTime(2021, 1, 14);
            DateTime date2NotNull = date2.GetValueOrDefault();

            Console.WriteLine(date2NotNull);

            Console.WriteLine("\nExemplo 3: Vc pode atribuir o valor de um tipo normal para um tipo nullable sem problemas.\n");
          
            DateTime? date3NotNull = date2NotNull;
            Console.WriteLine(date3NotNull);

            Console.WriteLine("\nExemplo 4: Null Coalescing Operator, o lendário\n");

            DateTime? date4Nullable = null;
            //Como ler a operação abaixo: Se o 1º valor não for nulo, use o 1º valor; se for nulo, use o 2º
            DateTime date4NotNull = date4Nullable ?? DateTime.Today;

            Console.WriteLine(date4NotNull);

            Console.WriteLine("\nPress a key to close...");
            Console.ReadKey();
        }
    }
}
