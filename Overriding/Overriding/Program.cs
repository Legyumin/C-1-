using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding
{
    class Program
    {

        class ArmorSuite
        {
            public void Initialize()
            {
                Console.WriteLine("Armored");
            }
        }

        class Iroman : ArmorSuite
        {
            public new void Initialize()
            {
                base.Initialize();
                Console.WriteLine("Repulsor Rays Aremd");
            }
        }

        class WarMachine : ArmorSuite
        {
            public new void Initialize()
            {
                base.Initialize();
                Console.WriteLine("Double-Barrel Cannos Armed");
                Console.WriteLine("Micro-Barrel Cannos Armed");
            }
        }
        static void Main(string[] args)
        {
            ArmorSuite armorsuite = new ArmorSuite();
            armorsuite.Initialize();
            Iroman iroman = new Iroman();
            iroman.Initialize();
        }
    }
}
