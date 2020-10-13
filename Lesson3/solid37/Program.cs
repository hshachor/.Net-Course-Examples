using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid37
{
    class grandfather
    {
        public virtual string hello()
        {
            return ("hello from grandfather");
        }
    }
    class father : grandfather
    {
        public override string hello()
        {
            return ("hello from father");
        }
    }
    class son : father
    {
        public override string hello()
        {
            return ("hello from son");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            grandfather[] arr = new grandfather[3];
            arr[0] = new grandfather();
            arr[1] = new father();
            arr[2] = new son();

            for (int i = 0; i < 3; i++)
                if (arr[i] is father)
                    Console.WriteLine(arr[i].hello());
        }
    }
}
