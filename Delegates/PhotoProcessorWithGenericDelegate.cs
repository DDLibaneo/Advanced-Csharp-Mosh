using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    public class PhotoProcessorWithGenericDelegate
    {
        // Action é um delegate generico do .NET para metodos que retornam void
        // Func é um delegate generico do .NET para metodos que retornam um valor
        public void Process(string path, Action<Photo> filterHandler)
        {
            var photo = Photo.Load(path);

            filterHandler(photo);

            photo.Save();
        }
    }
}
