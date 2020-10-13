using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid31
{
    class Program
    {
        class PetOwner

        {
            public string Name { get; set; }
            public List<String> Pets { get; set; }
        }

        public static void SelectManyEx1()
        {
            PetOwner[] petOwners =
                { new PetOwner { Name="Higa, Sidney",
                          Pets = new List<string>{ "Scruffy", "Sam" } },
                      new PetOwner { Name="Ashkenazi, Ronen",
                          Pets = new List<string>{ "Walker", "Sugar" } },
                      new PetOwner { Name="Price, Vernette",
                          Pets = new List<string>{ "Scratches", "Diesel" } } };

            // Query using SelectMany().
            IEnumerable<string> query1 = petOwners.SelectMany(petOwner => petOwner.Pets);

            Console.WriteLine("Using SelectMany():");

            // Only one foreach loop is required to iterate 
            // through the results since it is a
            // one-dimensional collection.
            foreach (string pet in query1)
            {
                Console.WriteLine(pet);
            }

            // This code shows how to use Select() 
            // instead of SelectMany().
            IEnumerable<List<String>> query2 =
                petOwners.Select(petOwner => petOwner.Pets);

            Console.WriteLine("\nUsing Select():");

            // Notice that two foreach loops are required to 
            // iterate through the results
            // because the query returns a collection of arrays.
            foreach (List<String> petList in query2)
            {
                foreach (string pet in petList)
                {
                    Console.WriteLine(pet);
                }
                Console.WriteLine();
            }
        }

        public static void Ex1()
        {
            string[] text = { "Albert was here",
                  "Burke slept late",
                  "Connor is happy" };

            var tokens = text.SelectMany(s => s.Split(' '));

            //foreach (string[] line in tokens)
                foreach (string token in tokens)
                    Console.Write("{0}.", token);
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Ex1();

            //SelectManyEx1();

        }
    }
}
