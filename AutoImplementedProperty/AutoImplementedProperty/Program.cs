using System;

namespace AutoImplementedProperty
{
    class BirthdayInfo
    {

        public string Name
        {
            get;
            set;

        } = "Unknown";
        public DateTime Birthday
        {
            get;
            set;

        } = new DateTime(2002, 9, 4);

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
            BirthdayInfo birth = new BirthdayInfo();
            Console.WriteLine("{0} {1} {2}", birth.Name, birth.Birthday, birth.Age);
            birth.Name = "규민";
            birth.Birthday = new DateTime(2002, 09, 04);
            Console.WriteLine("{0} {1} {2}", birth.Name, birth.Birthday, birth.Age);
        }
    }
}
