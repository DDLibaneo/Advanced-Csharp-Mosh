using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandling
{
    public class YoutubeException : Exception
    {
        public YoutubeException(string message, Exception innerException)
            : base(message, innerException)
        {

        }
    }
}
