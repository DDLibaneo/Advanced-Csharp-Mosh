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

            //var videoEncoder = new VideoEncoderNormal();
            var videoEncoder = new VideoEncoderUsingEvents();

            videoEncoder.Encode(video);

            Console.WriteLine("Press a key to close...");
            Console.ReadKey();
        }

        public class MailService
        {

        }
    }
}
