using System;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string post = "This is supposed to be a very long blog post bla bla bla...";

            var shortenedPost = post.Shorten(5);

            Console.WriteLine(shortenedPost);

            Console.WriteLine("Press a key to close...");
            Console.ReadKey();
        }
    }
}
