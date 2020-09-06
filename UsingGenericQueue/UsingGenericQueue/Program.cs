using System;
using System.Collections.Generic;

namespace UsingGenricQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < 5; i++)
            {
                queue.Enqueue(i + 1);
            }
            while (queue.Count > 0)
                Console.WriteLine(queue.Dequeue());
        }
    }
}