using System;

namespace EventsAndDelegates
{
    public class MailService
    {
        public MailService() { }

        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("MailService: Sending an Email... " + e.Video.Title);
        }
    }
}
