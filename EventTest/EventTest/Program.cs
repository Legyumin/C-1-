﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventTest
{
    delegate void EventHandler(string message);

    class MyNotifier
    {
        public event EventHandler SomethingHappend;
        public void DoSomething(int number)
        {
            int temp = number % 10;
            if (temp != 0 && temp % 3 == 0)
            {
                SomethingHappend(String.Format("{0} : 짝", number));
            }
        }
    }
    class Program
    {
        static public void MyHandler(string message)
        {
            Console.WriteLine(message);
        }
        static void Main(string[] args)
        {
            MyNotifier notifier = new MyNotifier();
            notifier.SomethingHappend += new EventHandler(MyHandler);
            for (int i = 0; i < 30; i++)
            {
                notifier.DoSomething(i);
            }
        }
    }
}