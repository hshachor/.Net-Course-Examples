using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace solid10 //base
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Dog d1 = new Dog("Tom");
            d1.SaySomething();

            Dog d2 = new Dog("Jerry");
            d2.SaySomeAnimalThing();

            
            Animal a3 = new Dog("Alice");
            Animal a4 = new Animal("Bob");

            Animal a1 = d1;
            Dog d3 = (Dog) a3;
            if (a3 is Dog) { }

        }
    }
    class Animal
    {
        protected string name;
        public Animal(string name)
        {
            this.name = name;
            System.Console.WriteLine("An Animal named {0} was born", name);
        }
        public void SaySomething()
        {
            System.Console.WriteLine("{0} Says Wraaaaaa", name);
        }
    }
    class Dog : Animal
    {
        public Dog(string name)
            : base(name)
        {
            System.Console.WriteLine("Dog named {0} was born", name);
        }
        public void SaySomething()
        {
            System.Console.WriteLine("{0} Says HawHaw", name);
        }
        public void SaySomeAnimalThing()
        {
            base.SaySomething();
            System.Console.WriteLine("But I Prefer:");
            this.SaySomething();
        }
    }
}


