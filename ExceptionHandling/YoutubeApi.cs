using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandling
{
    public class YoutubeApi
    {
        public List<Video> GetVideos(string user)
        {
            try
            {
                // Access YouTube web service
                // Read the Data
                // Create a list of Video objects

                throw new Exception("There was a youtube error");
            }
            catch(Exception ex)
            {
                // Log it somewhere
                throw new YoutubeException("Could not fetch video from youtube.", ex);
            }

            return new List<Video>();
        }
    }
}
