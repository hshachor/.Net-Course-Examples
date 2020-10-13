using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid40
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Burke", "Connor", "Frank", "Everett", "Albert", "George", "Harris", "David" };

            var s1 = names.OrderBy(s => s);
            var s2 = names.OrderByDescending(s => s);

            var s3 = names.OrderBy(s => s.Length);
            var s4 = names.OrderByDescending(s => s.Length);

            foreach (var item in s2)
                Console.WriteLine(item);
        }
    }
}
