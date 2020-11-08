using System;

namespace Generics
{
    public class Utilities
    {
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        // Exemplo: O metodo com genericos abaixo não funcionaria
        //public T Max<T>(T a, T b)
        //{
        //    return a > b ? a : b;
        //}

        public T Max<T>(T a, T b) where T : IComparable
        {
            return a.CompareTo(b) > 0 ? a : b;
        }

        // Types of constraints:
        // where T : IComparable
        // where T : Product (a class)
        // where T : struct
        // where T : class ('has to be a reference type' - mosh)
        // where T : new() ('has to have a default constructor' - mosh)

    }
}
