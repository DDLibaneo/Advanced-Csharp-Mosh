using System;

namespace EventsAndDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() 
            { 
                Title = "Video" 
            };

            var videoEncoder = new VideoEncoder();

            videoEncoder.Encode(video);

            Console.WriteLine("Press a key to close...");
            Console.ReadKey();
        }
    }
}
