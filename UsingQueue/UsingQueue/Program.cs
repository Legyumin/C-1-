﻿using System;
using System.Collections;
namespace UsingQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue que = new Queue();
            que.Enqueue(1);
            que.Enqueue(2);
            que.Enqueue(3);
            que.Enqueue(4);
            que.Enqueue(5);
            que.Enqueue(01);


            while (que.Count > 0)
                Console.WriteLine(que.Dequeue());
        }
    }
}
