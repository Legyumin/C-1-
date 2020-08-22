using System;

namespace Ex9_1
{
    class NameCard
    {
        private int age;
        private string name;

        public int Age
        {
            get; set;
        }

        public string Name
        {
            get; set;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            NameCard MyCard = new NameCard();
            MyCard.Age = 24;
            MyCard.Name = "상현";
            Console.WriteLine("나이 : {0}", MyCard.Age);
            Console.WriteLine("이름 : {0}", MyCard.Name);
        }
    }
}
