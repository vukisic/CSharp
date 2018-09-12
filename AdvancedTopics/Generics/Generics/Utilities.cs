using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    
    public class Utilities<T> where T : IComparable, new()
    {
        public T Max(T first,T second)
        {
            return first.CompareTo(second)> 0? first : second;
        }

        public void DoSomething(T value)
        {
            //Instance
            value = new T();
        }
    }
}
