﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex3
{
    // public delegate void PrinterEventHandler();

    public class MyPrinter_1
    {
        public event EventHandler<EventArgsPages> PageOver;
        private int pageCount = 20;

        /// <summary>
        /// this function will run when
        /// page printer over
        /// </summary>
        private void DoPageOver(int needed)
        {
            // do something
            if (PageOver != null)
                PageOver(this, new EventArgsPages(needed));
        }

        public void Print(int pageNumber)
        {
            this.pageCount -= pageNumber;
            if (pageCount <= 0)
            {
                DoPageOver(pageCount);
                pageCount = 0;
            }
        }
    }
    class User1
    {
        MyPrinter_1 printer;
        public User1(MyPrinter_1 printer)
        {
            this.printer = printer;
            this.printer.PageOver += User1DoPageOver;
            // this.printer.PageOver = User1DoPageOver;
        }

        private void User1DoPageOver(object sender, EventArgsPages e)
        {
            // do something
            Console.WriteLine($"Please bring {e.NeededPages}...");
        }
    }

    class User2
    {
        MyPrinter_1 printer;
        public User2(MyPrinter_1 printer)
        {
            this.printer = printer;
            this.printer.PageOver += User2DoPageOver;
        }

        private void User2DoPageOver(object sender, EventArgs e)
        {
            // do something
            Console.WriteLine("user 2 do ...");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            MyPrinter_1 p = new MyPrinter_1();
            User1 u1 = new User1(p);
            User2 u2 = new User2(p);
            Console.WriteLine("enter page of copy :");
            int x = int.Parse(Console.ReadLine());
            p.Print(x);
        }
    }

    public class EventArgsPages : EventArgs
    {
        public readonly int NeededPages;
        public EventArgsPages(int needed)
        {
            NeededPages = needed;
        }
    }
}
