using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    public static class StringExtension
    {
        //Convention is public static and static class
        public static string Shorten(this String str, int numOfWords)
        {
            if (numOfWords < 0)
                throw new ArgumentOutOfRangeException("numberOfWords must be equal or grater than zero!");
            if (numOfWords == 0)
                return "";

            var words = str.Split(' ');
            if (words.Length < numOfWords)
                return str;

            return string.Join(" ", words.Take(numOfWords))+"...";
        }

    }
}
