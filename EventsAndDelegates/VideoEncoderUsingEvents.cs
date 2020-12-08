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
        // Abaixo um exemplo de assinatura com EventArgs de parametro
        // public delegate void VideoEncodedEventHandler(object source, EventArgs args);

        // Abaixo a forma antiga de se criar um evento, criando um delegate para usar no evento
        // public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);
        // public event VideoEncodedEventHandler VideoEncoded;        

        // Abaixo o jeito moderno de criar um evento, com o delegate type EventHandler
        // O exemplo abaixo é equivalente ao exemplo acima.
        public event EventHandler<VideoEventArgs> VideoEncoded;

        // exemplo sem mandar um objeto ao subscriber:
        // public event EventHandler VideoEncoded;

        public void Encode(Video video)
        {
            System.Console.WriteLine("Encoding video...");
            Thread.Sleep(2000);

            OnVideoEncoded(video);
        }

        // This is the method that raises the event
        // Will notify all subscribers of this event
        protected virtual void OnVideoEncoded(Video video)
        {
            // the source of this event, or the publisher of this event, is
            // this class / object. So we pass "this" as the first argument
            // Exemplo abaixo usando EventArgs com invoke
            // VideoEncoded?.Invoke(this, EventArgs.Empty);

            // Exemplo abaixo usando EventArgs com um if
            // if (VideoEncoded != null)
            //   VideoEncoded(this, EventArgs.Empty);,

            // Exemplo abaixo passando um objeto de Video como parametroa
            VideoEncoded?.Invoke(this, new VideoEventArgs() { Video = video });
        }
    }
}
