using System;

namespace ConsoleEx2
{
    class Program
    {
        static void Main(string[] args)
        {
            string Len="12345678901234567890";
            First(Len);
            Console.WriteLine("==================");
            Second(Len);
            Console.WriteLine("==================");
            Third(Len);
            Console.WriteLine("==================");
            Fourth(Len);      
            Console.WriteLine("==================");
            Five(Len);
            Console.WriteLine("==================");
            Sixth(Len);
        }

        public static void First(string Len)
        {
            int money=5;
            Console.WriteLine("1.以貨幣方式C|c顯示資料，以NT$開頭====");
            Console.WriteLine(Len);
            Console.WriteLine($"{money,0:C}{-money,11:c3}");
            Console.WriteLine($"{-money,15:C3}");
            Console.WriteLine($"{-money,-15:C3}");
        }

        public static void Second(string Len)
        {
            int number=25;
            Console.WriteLine("2.以十進位方式D|d顯示資料，空白處補零====");
            Console.WriteLine(Len);
            Console.WriteLine($"{number,0:D5}");
            Console.WriteLine($"{number,10:D5}");
            Console.WriteLine($"{-number,-10:D5}");
        }

        public static void Third(string Len)
        {
           
            Console.WriteLine("3.以指數E方式 顯示資料====");
            Console.WriteLine(Len);
            Console.WriteLine($"{250000,0:E}");
            Console.WriteLine($"{25000,0:E3}");
            Console.WriteLine($"{0.0012345,0:E3}");
            Console.WriteLine($"{25000,20:E3}");
            Console.WriteLine($"{-25000,-20:E3}");
        }
        public static void Fourth(string Len)
        {
           
            Console.WriteLine("4.以浮點方式F|f 顯示資料====");
            Console.WriteLine(Len);
            Console.WriteLine($"{123.4567,-20:f2}");
            Console.WriteLine($"{123.4567,-20:f0}");
            Console.WriteLine($"{123.456,-20:F3}");
            Console.WriteLine($"{123.4567,20:f3}");
            Console.WriteLine($"{123.45,-20:F3}");
        }
         public static void Five(string Len)
        {
            Console.WriteLine("5.以一般方式G|g 顯示資料====");
            Console.WriteLine(Len);
            Console.WriteLine($"{123.4567,-20:G0}");
            Console.WriteLine($"{123.4567,0:G0}");
            Console.WriteLine($"{123.4567,0:G3}");
            Console.WriteLine($"{123.4567,20:G5}");
            Console.WriteLine($"{-123.4567,0:G3}");
        }
        public static void Sixth(string Len)
        {
            int i=2500000;
            Console.WriteLine("6.以千位符號,N|n 顯示資料，不加$====");
            Console.WriteLine(Len);
            Console.WriteLine($"{i:N2}");
            Console.WriteLine($"{i,0:N0}");
            Console.WriteLine($"{i,0:N1}");
            Console.WriteLine($"{-i,20:N2}");
            Console.WriteLine($"{i,-20:N2}");
        }
    }
}
