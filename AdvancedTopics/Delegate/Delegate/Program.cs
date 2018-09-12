using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Program
    {
        //System.Action<> -> points to a method without return value
        //System.Func<> -> points to a method with return value
        static void Main(string[] args)
        {
            PhotoProcessor photoProcessor = new PhotoProcessor();
            var filter = new PhotoFilter();
            Action<Photo> filterHandler = filter.Brightness;
            filterHandler += RedEyeFilter;
            photoProcessor.Process("photo.jpg", filterHandler);
        }

        //Separate filter
        public static void RedEyeFilter(Photo photo)
        {
            Console.WriteLine("RedEyes disabled!");
        }
    }
}
