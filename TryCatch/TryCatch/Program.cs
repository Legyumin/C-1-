using System;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };

            try
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(arr[i]);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine($"예외 발생 : {e.Message}");
            }
           
           /* catch(DivideByZeroException e)
            {
                Console.WriteLine($"예외 발생2 : {e.Message}");
            } */
        }
    }
}