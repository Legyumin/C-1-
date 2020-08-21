using System;

namespace ConstructorWithProperty
{
    class BirthdayInfo
    {

        public string Name
        {
            get;
            set;

        }
        public DateTime Birthday
        {
            get;
            set;

        }

        public int Age
        {
            get
            {
                return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BirthdayInfo birth = new BirthdayInfo()
            {
               Name = "규민",
               Birthday = new DateTime(2002,09,04)
              };
            Console.WriteLine("{0} {1} {2}", birth.Name, birth.Birthday, birth.Age);
        }
    }
}
