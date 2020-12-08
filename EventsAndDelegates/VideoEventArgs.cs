using System;
using System.Collections.Generic;
using System.Text;

namespace EventsAndDelegates
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }
}
