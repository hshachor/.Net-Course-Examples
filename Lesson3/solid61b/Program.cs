
// ניתן להשתמש בממשק ובמחלקת ההתאמות בכל תכנית אחרת מבלי לשנות את הקוד.
// לדוגמא: (3 מצורפת)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace solid61b
{
    interface ILike
    {
        bool Like(ILike other);
    }

    abstract class Animal
    {
        protected string name;
        protected Animal(string name)
        {
            this.name = name;
        }
        public override string ToString()
        {
            return name; ;
        }
    }

    class Dog : Animal, ILike
    {
        public Dog(string name) : base(name) { }

        public bool Like(ILike other)
        {
            return (other is Dog);
        }
    }
    class Cat : Animal, ILike
    {
        public Cat(string name) : base(name) { }

        public bool Like(ILike other)
        {
            return (other is Cat);
        }
    }
    class Lion : Animal, ILike
    {
        public Lion(string name) : base(name) { }

        public bool Like(ILike other)
        {
            return false;
        }
    }

    class Matcher
    {
        public void Match(ILike[] oa)
        {
            for (int i = 0; i < oa.Length; i++)  //1
            {
                for (int j = i + 1; j < oa.Length; j++)//2
                {
                    if ( //3
                        oa[i].Like(oa[j]) &&
                        oa[j].Like(oa[i])
                        )
                    {
                        System.Console.WriteLine(
                            "{0} Matches to {1}", oa[i], oa[j]);
                    }
                }
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            ILike[] all = new ILike[6];
            all[0] = new Lion("Lion A");
            all[1] = new Lion("Lion B");
            all[2] = new Dog("Dog A");
            all[3] = new Dog("Dog B");
            all[4] = new Cat("Cat A");
            all[5] = new Cat("Cat B");

            Matcher matcher = new Matcher();
            matcher.Match(all);

        }
    }
}




