using System.Threading;

namespace EventsAndDelegates
{
    internal class VideoEncoderNormal
    {
        public VideoEncoderNormal() { }

        public void Encode(Video video)
        {
            System.Console.WriteLine("Encoding video...");
            Thread.Sleep(2000);
        }
    }
}