using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public class PhotoProcessor
    {
        //Delegate -> pointer to a method with specific signature
        //This delegat can point to functions which type is void and have parameter of type Photo!
        //public delegate void PhotoFilterHandler(Photo photo);

        public void Process(string path,Action<Photo> photoFilter)
        {
            var photo = Photo.Load(path);

            photoFilter(photo);

            photo.Save();
        }
    }
}
