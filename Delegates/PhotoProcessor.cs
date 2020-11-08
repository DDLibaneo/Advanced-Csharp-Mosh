using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    public class PhotoProcessor
    {
        public delegate void PhotoFilterHandler(Photo photo); // our delegate
        // an instance of this delegate can hold a pointer to a function or a
        // group of function that have this signature (in this case void as 
        // return type, Photo object as parameter

        public void Process(string path, PhotoFilterHandler filterHandler)
        {
            var photo = Photo.Load(path);

            filterHandler(photo);

            photo.Save();
        }
    }
}
