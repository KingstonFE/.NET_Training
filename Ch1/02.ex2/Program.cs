using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Ex2_1();
            Ex2_2();
        }
        
        public static void Ex2_1()
        {
            Console.WriteLine("12345678901234567890");

            Console.Write("a.{0}",100);

            Console.Write("     b.{0}",-200);
            Console.WriteLine();


            Console.WriteLine("a.{0}     b.{1}",100,-200);
        }

        public static void Ex2_2()
        {
            int no1,no2;
            Console.Write("輸入第一個整數No1 : ");
            no1=int.Parse(Console.ReadLine());
            Console.Write("輸入第二個整數No2 : ");
            no2=int.Parse(Console.ReadLine());
            Console.WriteLine($"no1+no2={no1}+{no2}={no1+no2}");
        }
    }
}
