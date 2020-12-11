using System;
using System.Linq;

namespace System // Para sempre manter os metodos extendidos no escopo, podemos usar o system
{
    public static class StringExtensions //Como padrão de nome usamos NomeDaClasseExtendida + Extensions no final
    {
        // Escrevemos aqui os métodos de extensão
        // Um exemplo de Extension Methods que usamos no dia-dia é são os métodos de lambda do IEnumerable
        public static string Shorten(this String str, int numberOfWords)
        {
            if (numberOfWords < 0)
                throw new ArgumentOutOfRangeException("numberOfWords should be greater than or equal to 0.");

            if (numberOfWords == 0)
                return "";

            var words = str.Split(' ');

            if (words.Length <= numberOfWords)
                return str;

            return string.Join(" ", words.Take(numberOfWords));
        }
    }
}
