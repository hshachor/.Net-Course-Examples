using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;

namespace ThreadsConsole4
{
    class Account
    {
        private int balance;
        private readonly int interestRate; // integer % number
        private volatile bool _shouldStop;
        BackgroundWorker w;
        public Account(int initBalance, int interest)
        {
            balance = initBalance;
            interestRate = interest;
            w = new BackgroundWorker();
            w.DoWork += (o, e) =>
            {
                _shouldStop = false;
                while (!_shouldStop)
                {
                    //applyInterest();
                    w.ReportProgress(0);
                    Thread.Sleep(3000); // 3 seconds
                }
                Thread.Sleep(5000);  // 5 seconds delay
            };
            w.ProgressChanged += (o, e) =>
            {
                applyInterest();
            };
            w.WorkerReportsProgress = true;
            w.RunWorkerCompleted += (o,e) => { Console.WriteLine("worker competed"); };
            w.RunWorkerAsync();
        }

        public void Deposit(int amount)
        {
            timeOutput();
            out1("Deposit");
            balance += amount;
            out2();
        }

        public bool Withdraw(int amount)
        {
            timeOutput();
            if (amount > balance)
            {
                out1("No withdraw");
                out2();
                return false;
            }
            out1("Withdraw");
            balance -= amount;
            out2();
            return true;
        }

        private void applyInterest()
        {
            timeOutput();
            out1("applyInterest");
            balance = (balance * (100 + interestRate)) / 100;
            out2();
        }

        public void Close()
        {
            // NEVER ABORT A THREAD LIKE THIS: myThread.Abort(); // IT IS DANGEROUS
            timeOutput();
            Console.WriteLine("close: trying");
            _shouldStop = true;
        }

        public bool threadFinished(bool sync)
        {
            timeOutput();
            if (w == null)
            {
                Console.WriteLine("threadFinished: no thread");
                return true;
            }
            if (sync)
            {

                Console.WriteLine("threadFinished: joining");
                while (w.IsBusy) ;
                timeOutput();
                Console.WriteLine("threadFinished: true");

            }
            bool t = !w.IsBusy;
            Console.WriteLine("threadFinished: {0}", t);
            return t;
        }

        private void timeOutput()
        {
            Console.Write("print from thread {1} - {0}: ", DateTime.Now.ToString("HH:mm:ss"), SynchronizationContext.Current);
        }
        private void out1(string loc)
        {
            Console.Write("{0}: old balance = {1}, ", loc, balance, Thread.CurrentThread.ManagedThreadId);
        }
        private void out2()
        {
            Console.WriteLine("new balance = {0}, ", balance, Thread.CurrentThread.ManagedThreadId);
        }
    }

    class Program
    {
        static private Random rand = new Random();

        static void Main(string[] args)
        {
            Account myAccount = new Account(1000, 2);

            while (!myAccount.threadFinished(false))
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                switch (keyInfo.KeyChar)
                {
                    case '1':
                        myAccount.Deposit(rand.Next(100));
                        break;
                    case '2':
                        myAccount.Withdraw(rand.Next(200));
                        break;
                    case '0':
                        myAccount.Close();
                        myAccount.threadFinished(true);
                        //Thread.Sleep(200);
                        break;
                }
            }

        }
    }
}
