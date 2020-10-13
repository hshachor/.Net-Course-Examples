using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid61a
{
    interface ILike
    {
        bool Like(ILike other);
    }


    class Worker : ILike
    {
        private string name;
        private int salary;
        public int Salary
        {
            get
            {
                return salary;
            }
        }

        public Worker(string name, int salary)
        {
            this.name = name;
            this.salary = salary;
        }

        public virtual bool Like(ILike other)
        {
            return (other is Worker);
        }

        override public string ToString()
        {
            return name + ", Salary:" + salary;
        }
    }

    class Boss : Worker //3
    {
        public Boss(string name, int salary) : base(name, salary) { } //1
        public override bool Like(ILike other) //2
        {
            return (base.Like(other) && this.Salary <= ((Worker)other).Salary);
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

    class MainClass
    {
        static void Main(string[] args)
        {
            ILike[] all = new ILike[5];
            all[0] = new Worker("Worker A", 10);
            all[1] = new Worker("Worker B", 20);
            all[2] = new Worker("Worker C", 30);
            all[3] = new Boss("Boss AAB", 20);
            all[4] = new Boss("Boss BBB", 20);

            Matcher matcher = new Matcher();
            matcher.Match(all);
        }
    }
}