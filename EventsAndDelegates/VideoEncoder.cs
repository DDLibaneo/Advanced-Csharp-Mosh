using System.Threading;

namespace EventsAndDelegates
{
    internal class VideoEncoder
    {
        public VideoEncoder() { }

        public void Encode(Video video)
        {
            System.Console.WriteLine("Encoding video...");
            Thread.Sleep(2000);
        }
    }
}