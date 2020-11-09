using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    public class PhotoProcessorOld
    {
        public void Process(string path)
        {
            var photo = Photo.Load(path);

            var filters = new PhotoFilters();
            filters.ApplyBrightness(photo);
            filters.ApplyContrast(photo);
            filters.Resize(photo);

            photo.Save();
        }
    }
}
