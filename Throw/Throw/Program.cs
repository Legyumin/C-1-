using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Throw
{
    class Program
    {
        static void DoSometing(int arg)
        {
            if (arg < 10)
                Console.WriteLine($"arg : {arg}");
            else
                throw new Exception("arg가 10보다 큽니다.");
        }
        static void Main(string[] args)
        {
            try
            {
                for (int i = 1; i < 15; i += 2)
                {
                    DoSometing(i);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}