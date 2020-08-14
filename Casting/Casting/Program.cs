
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting
{
    class Mamma1
    {
        public Mamma1()
        {
            Console.WriteLine("Hello Mammal");
        }
        public void Nurse()
        {
            Console.WriteLine("동물을 길러요.");
        }
    }

    class Dog : Mamma1
    {
        public Dog()
        {
            Console.WriteLine("Hello Dog");
        }
        public void Bark()
        {
            Console.WriteLine("멍멍~");
        }
    }

    class Cat : Mamma1
    {
        public Cat()
        {
            Console.WriteLine("Hello Cat");
        }
        public void Meow()
        {
            Console.WriteLine("냐옹~");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Mamma1 m = new Mamma1();
            Dog d = new Dog();
            m.Nurse();
            d.Nurse();d.Bark();

            Mamma1 mc = new Cat(); //다운 캐스트
            mc.Nurse(); //Mc.Meow();

            // Cat cm = new Mamma1(); //업 캐스트 불가 
                   }
    }
}
