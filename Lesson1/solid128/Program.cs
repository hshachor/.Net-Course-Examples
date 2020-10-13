using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace solide128
{
    enum Family { Abba, Mother, בן1, בן2, Bat1, NumberPeople }
    enum Food { steak, chocolate, pizza, bread, ice_cream }

    class FirstProgram
    {
        static void Main(string[] args)
        {
            Food[] favorites = new Food[(int)Family.NumberPeople];
            favorites[(int)Family.Abba] = Food.steak;
            for (int i = 0; i < favorites.Length; i++)
                favorites[i] = (Food)i;

            foreach (Food f in favorites)
                Console.WriteLine("{0} is favorite of {1} ", f, (Family)f);
        }



    }
}
