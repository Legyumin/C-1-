using System;

namespace _2DArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            for(int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1);j++)
                {
                    Console.WriteLine($"[{i},{j}] : { arr[i,j]} "); 
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
