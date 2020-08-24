using System;

namespace InintializingArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = new string[3] { "안녕", "Hello", "Helo" };
            foreach (string greeting in array1)
            {
                Console.WriteLine($" {greeting}");
            }
            Console.WriteLine();

            string[] array2 = new string[] {"안녕", "Hello","Helo"};
            foreach (string greeting in array2)
            {
                Console.WriteLine($" {greeting}");
            }
            Console.WriteLine();
            string[] array3 = { "안녕", "Hello", "Helo" };
            foreach (string greeting in array2)
            {
                Console.WriteLine($" {greeting}");
            }
        }
    }
}
