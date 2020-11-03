using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex1
{
    public delegate void PrinterEventHandler();

    public class MyPrinter_1
    {
        public PrinterEventHandler PageOver;
        private int pageCount = 20;

        /// <summary>
        /// this function will run when
        /// page printer over
        /// </summary>
        private void DoPageOver()
        {

            // do something
            if (PageOver != null)
                PageOver();
        }

        public void Print(int pageNumber)
        {
            this.pageCount -= pageNumber;
            if (pageCount <= 0)
            {
                pageCount = 0;
                DoPageOver();
            }
        }
    }

    class User
    {
        MyPrinter_1 printer;

        public User(MyPrinter_1 printer, string name)
        {
            this.printer = printer;
            this.printer.PageOver = () => User1DoPageOver(name);
        }

        private void User1DoPageOver(string name)
        {
            // do something
            Console.WriteLine($"user {name} do ...");
        }
    }
    /*
    class User2
    {
        MyPrinter_1 printer;
        public User2(MyPrinter_1 printer)
        {
            this.printer = printer;
            PrinterEventHandler p = new PrinterEventHandler(printer_PageOver);
            this.printer.PageOver += User2DoPageOver;
        }

        void printer_PageOver()
        {

        }

        private void User2DoPageOver()
        {
            // do something
            Console.WriteLine("user 2 do ...");
        }
    }

    */
    class Program
    {
        static void Main(string[] args)
        {

            string str = null;
            str += "ljlj";

            MyPrinter_1 p = new MyPrinter_1();
            User u1 = new User(p, "Haim");
            User u2 = new User(p, "Dani");
            
            Console.WriteLine("enter page of copy :");
            int x = int.Parse(Console.ReadLine());
            p.Print(x);


        }
    }
}
