using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exeption
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int i = int.Parse("a5");
                Console.WriteLine(i);
                throw new ArgumentNullException();
            }
            catch (Exception e)
            {
                e.
                // Do something 
                int j = int.Parse("abc");
            }
            finally
            {
                Console.WriteLine("exiting main function\n");
            }
        }
    }
}
