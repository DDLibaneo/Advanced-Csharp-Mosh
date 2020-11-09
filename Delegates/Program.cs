using System;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exemplo sem delegate
            ExampleWithNoDelegates();

            // Exemplo com delegate original
            ExampleWithOriginalDelegate();

            // Exemplo com delegate generico (Action)
            ExampleWithGenericDelegate();

            Console.WriteLine("Press a key to close...");
            Console.ReadKey();
        }

        public static void ExampleWithGenericDelegate()
        {
            var processor = new PhotoProcessorWithGenericDelegate();

            var filters = new PhotoFilters();

            Action<Photo> filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            filterHandler += filters.Resize;
            filterHandler += RemoveRedEyeFilter;

            processor.Process("photo.jpg", filterHandler);
        }

        public static void ExampleWithOriginalDelegate()
        {
            var processor = new PhotoProcessor();

            var filters = new PhotoFilters();

            PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            filterHandler += filters.Resize;
            filterHandler += RemoveRedEyeFilter; // exemplo de extensão

            processor.Process("photo.jpg", filterHandler);
        }

        public static void ExampleWithNoDelegates()
        {
            var processor = new PhotoProcessorOld();
            processor.Process("photo.jpg");
        }

        // example on extensibility using delegates: assign an original method to an 
        // existing delegate in a library
        static void RemoveRedEyeFilter(Photo photo)
        {
            Console.WriteLine("Apply 'Remove Red Eyes'");
        }
    }
}
