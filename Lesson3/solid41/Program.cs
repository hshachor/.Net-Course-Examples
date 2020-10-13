using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid41
{
    class grandfather
    {
        public override string ToString()
        {
            return "grandfather";
        }
    }
    class father : grandfather
    {
        public override string ToString()
        {
            return "father";
        }
    }
    class son : father
    {
        public override string ToString()
        {
            return "son";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            grandfather g = new father();
            father f = g as father; //instead of using casting
                                    //father f = (father) g;
                                    //casting can cause run time error
                                    // ( if g is not a father)
                                    // And casting is expensive
            son s = g as son;
            Console.WriteLine(g);
            Console.WriteLine(f);
            Console.WriteLine(s); //null!!
        }
    }
}
