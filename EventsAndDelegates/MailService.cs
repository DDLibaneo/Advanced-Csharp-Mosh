using System;

namespace EventsAndDelegates
{
    public class MailService
    {
        public MailService() { }

        public void OnVideoEncoded(object source, EventArgs e)
        {
            Console.WriteLine("MailService: Sending an Email...");
        }
    }
}
