using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace StringFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            String result1 = string.Format("ABC{0,10}GHI","DEF");
            String result2 = string.Format("ABC{0,-10}GHI", "DEF");
            Console.WriteLine(result1);
            Console.WriteLine(result2);

            string fmt = "{0,-20}{1,-15}{2,30}";

            Console.WriteLine(fmt, "Phublisher", "Author", "Title");
            Console.WriteLine(fmt, "Marvel", "Stan Lee", "Iron Man");
            Console.WriteLine(fmt, "Hanbit", "Sanghyun Park", "C# 7.0 programming");

            Console.WriteLine("10진수 : {0:D}", 123);
            Console.WriteLine("10진수 : {0:D5}", 123);
            Console.WriteLine("16진수 : {0:X}", 0xFF1234);
            Console.WriteLine("16진수 : {0:X8}", 0xFF1234);
            Console.WriteLine("숫자 : {0:N}", 123456789);
            Console.WriteLine("숫자 : {0:N0}", 123456789);
            Console.WriteLine("고정소수점 : {0:F}",123.45);
            Console.WriteLine("고정소수점 : {0:F5}",123.45);
            Console.WriteLine("지수: {0:E}", 123.456789);


            DateTime dt = new DateTime(2020, 8, 12, 16, 4, 22);
            Console.WriteLine("12 시간 : {0:yyyy-MM-dd tt hh:mm:ss (ddd)}", dt);
            Console.WriteLine("24 시간 : {0:yyyy-MM-dd HH:mm:ss (dddd)}", dt);

            CultureInfo ciKo = new CultureInfo("ko-KR");
            Console.WriteLine(dt.ToString("yyyy-MM-dd tt hh:mm:ss (ddd)", ciKo));
            Console.WriteLine(dt.ToString("yyyy-MM-dd HH:mm:ss (ddd)", ciKo));

            int number = 30112;
            String name = "이규민";
            Console.WriteLine($"{number:D}{name,10}");   //Console.WriteLine("{0:D} {1,10}",number,name);
        }
    }
}
