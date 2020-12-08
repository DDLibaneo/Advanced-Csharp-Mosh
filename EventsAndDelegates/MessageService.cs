using System;
using System.Collections.Generic;
using System.Text;

namespace EventsAndDelegates
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs eventArgs)
        {
            Console.WriteLine("MessageService: Sending a text message... " + eventArgs.Video.Title);
        }
    }
}
