using System;
using System.Collections;

namespace UsingList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            /* list.Add(0);
             list.Add(1);
             list.Add(2);
             list.Add(3);
             list.Add(4);*/
            for (int i = 0; i < 5; i++)
                list.Add(i);
            foreach (object obj in list)
                Console.Write($"{obj}");
            Console.WriteLine();

            list.RemoveAt(2);
            foreach (object obj in list)
                Console.Write($"{obj}");
            Console.WriteLine();

            list.Insert(2, 200);
            foreach (object obj in list)
                Console.Write($"{obj}");
            Console.WriteLine();

            list.Add("abc");
        }
    }
}
