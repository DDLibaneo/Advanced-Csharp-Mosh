using System;

namespace EventsAndDelegates
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() 
            { 
                Title = "Video" 
            };

            //var videoEncoder = new VideoEncoderNormal();
            var videoEncoder = new VideoEncoderUsingEvents(); // publisher
            var mailService = new MailService(); // subscriber 

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;

            videoEncoder.Encode(video);

            Console.WriteLine("Press a key to close...");
            Console.ReadKey();
        }
    }
}
