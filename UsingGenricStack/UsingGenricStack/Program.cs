using System;
using System.Collections.Generic;

namespace usingGenricStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < 5; i++)
                stack.Push(i + 1);

            while (stack.Count > 0)
                Console.WriteLine(stack.Pop());
        }
    }
}