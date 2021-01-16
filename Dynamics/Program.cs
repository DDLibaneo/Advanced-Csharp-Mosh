using System;

namespace Dynamics
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exemplo de Reflection
            object obj = "Mosh";

            // pegando hashCode sem reflection
            obj.GetHashCode();

            // pegando hashcode com reflection
            var methodInfo = obj.GetType().GetMethod("GetHashCode", new Type[] { });            
            // chamando o método 
            var result = methodInfo.Invoke(obj, null);

            // Com um dynamic object voce não precisa se preocupar com usar reflection
            // para chamar um método de um objeto anonimo.

            dynamic excelObject = "mosh";
            try 
            {
                excelObject.Optimize();
            }
            catch { }

            // O compilador não reclama de não ter achado o método Optimize(), pois ele vai busca-lo no
            // runtime. E não vai achar no runtime, dando Exception.

            // CLR: Common Language Runtime é a Máquina Virtual do .NET que pega seu codigo compilado 
            // (que é uma linguagem intermediária ou IL) e converte isso em código de máquina em runtime.
            // no .NET 4 adicionaram um novo componente que é o DLR, que é Dynamic Language Runtime.
            // O DLR fica em cima do CLR, e dá capacidades dinamicas para o C#. Linguagens tipadas dinamicamente
            // de exemplo são Python, Ruby e js. 

            // vc pode atribuir valores de tipos diferentes para a mesma variavel dinamica, não vai dar ruim.
            // o tipo da variavel vai mudar automaticamente no runtime. Vc pode ver isso no Watch. Do Visual 
            // Studio
            dynamic name = "mosh";
            name = 10;

            // Exemplos de conversão e casting com tipos dinamicos
            int i = 5;

            // No runtime, d vai acabar sendo um dynamic tipo inteiro
            dynamic d = i;

            // Isso tambem vai dar certo.
            long l = d;

            Console.WriteLine("Press a key to close...");
            Console.ReadKey();
        }
    }
}
