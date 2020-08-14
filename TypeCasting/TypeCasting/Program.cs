using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeCasting
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
            Mamma1 mammal = new Dog();
            Dog dog;

            if (mammal is Dog)
            {
                dog = (Dog)mammal;
                dog.Bark();
            }
            Mamma1 mammal2 = new Cat();

            Cat cat = mammal2 as Cat;
            if (cat != null)
                cat.Meow();

            Cat cat2 = mammal as Cat;
            if (cat2 != null)
                cat2.Meow();
            else
                Console.WriteLine("cat2 is not a Cat");
        }
    }
}
