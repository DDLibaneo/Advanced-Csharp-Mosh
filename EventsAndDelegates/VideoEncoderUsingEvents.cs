using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EventsAndDelegates
{
    public class VideoEncoderUsingEvents
    {
        // Steps to implement an event where at the end we notify anyone interested in this event
        // 1- Define a delegate
        // 2- Define an event based on that delegate
        // 3- Raise or 'publish' the event

        public VideoEncoderUsingEvents() { }

        // The next line is the conventional signature for event handlers
        // The first parameter is an object that is the source of the event, or the class that
        // is 'publishing' or sending the event.
        // The second paramater is an EventArgs, which is basically any additional data we want
        // to send to the event 

        // Remember: a delegate stores references to methods that have the specified signature
        public delegate void VideoEncodedEventHandler(object source, EventArgs args);

        public event VideoEncodedEventHandler VideoEncoded;        

        public void Encode(Video video)
        {
            System.Console.WriteLine("Encoding video...");
            Thread.Sleep(2000);

            OnVideoEncoded();
        }

        // This is the method that raises the event
        // Will notify all subscribers of this event
        protected virtual void OnVideoEncoded()
        {
            // the source of this event, or the publisher of this event, is
            // this class / object. So we pass "this" as the first argument
            VideoEncoded?.Invoke(this, EventArgs.Empty);

            // jeito normal:
            //if (VideoEncoded != null)
            //    VideoEncoded(this, EventArgs.Empty);
        }
    }
}
