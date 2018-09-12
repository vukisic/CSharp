using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public class PhotoFilter
    {
        public void Resize(Photo photo)
        {
            Console.WriteLine("Resize photo!");
        }

        public void Contrast(Photo photo)
        {
            Console.WriteLine("Contrast photo!");
        }

        public void Brightness(Photo photo)
        {
            Console.WriteLine("Brightness photo!");
        }
    }
}
