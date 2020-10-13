using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex2
{
    public class GenericWhere1<T, U> where T : U
    {
        U[] arr;
        public GenericWhere1(T t, U u)
        {
            arr = new U[] { t, u };
        }
    }

    public class GenericWhere2<T> where T : class
    {
        T t;
        public GenericWhere2()
        {
            t = null;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}


