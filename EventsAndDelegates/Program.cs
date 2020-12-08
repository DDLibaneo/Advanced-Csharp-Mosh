using System;

namespace EventsAndDelegates
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() 
            { 
                Title = "Video Exemplo" 
            };

            //var videoEncoder = new VideoEncoderNormal();
            var videoEncoder = new VideoEncoderUsingEvents(); // publisher
            var mailService = new MailService(); // subscriber 
            var messageService = new MessageService(); // subscriber

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;

            videoEncoder.Encode(video);

            Console.WriteLine("Press a key to close...");
            Console.ReadKey();
        }
    }
}
