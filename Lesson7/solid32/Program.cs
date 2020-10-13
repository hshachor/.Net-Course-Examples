using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid32
{
    class Program
    {
        public static void ex3()
        {
            IEnumerable<int> arr1 =
                 new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }; IEnumerable<int> arr2 =
          arr1.
            Where(i => i % 2 == 0).
                Select(item => item * 2);
            foreach (var item in arr2) Console.WriteLine(item);
        }

        class person
        {
            public int id { get; set; }
            public string name { get; set; }

            public override string ToString()
            {
                return string.Format("id= {0}  name= {1} ", id, name);
            }
        }

        public static void ex4()
        {

            string[] names = { "Burke", "Connor", "Frank", "Everett",
                   "Albert", "George", "Harris", "David" };

            person[] people = {
                    new person { id = 123, name = "Frank" },
                    new person { id = 456, name = "George" },
                    new person { id = 789, name ="Harris" }
            };

            var query = names.SelectMany(n =>people.Where(p => n.Equals(p.name)));

            foreach (var item in query)
                Console.WriteLine(item);
        }

        static void Main(string[] args)
        {
            ex3();


        }
    }
}
