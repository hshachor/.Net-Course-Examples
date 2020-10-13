using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// מקביל לדוגמא EX91
/// </summary>
namespace solid14
{
    class Worker
    {
        virtual public void SaySomething() // Define the base method as virtual
        {
            System.Console.WriteLine("Emplyee: What should I do ?");
        }
    }
    class Manager : Worker
    {
        override public void SaySomething() // override the virtual method of the worker
        {
            System.Console.WriteLine("Manager: Start working !");
        }
    }
    class President : Manager
    {
        override public void SaySomething() //override the virtual method of the manager.
        {
            System.Console.WriteLine("President: What's the revenue?");
        }
    }
    class Polymorphism
    {

        static void Main(string[] args)
        {
            Worker[] workers = new Worker[3];
            workers[0] = new Worker(); // 
            workers[1] = new Manager();
            workers[2] = new President();
            for (int i = 0; i < 3; i++)
                workers[i].SaySomething();
            System.Console.ReadLine();
        }

    }

}

