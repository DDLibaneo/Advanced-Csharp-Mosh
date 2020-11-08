using System;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exemplo sem delegate
            //var processor = new PhotoProcessorOld();
            //processor.Process("photo.jpg");

            // Exemplo com delegate

            var processor = new PhotoProcessor();

            var filters = new PhotoFilters();

            PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            filterHandler += filters.Resize;
            filterHandler += RemoveRedEyeFilter;

            processor.Process("photo.jpg", filterHandler);

            Console.WriteLine("Press a key to close...");
            Console.ReadKey();
        }

        // example on extensibility using delegates: assign an original method to an 
        // existing delegate in a library
        static void RemoveRedEyeFilter(Photo photo)
        {
            Console.WriteLine("Apply 'Remove Red Eyes'");
        }
    }
}
