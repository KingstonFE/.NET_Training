using System;

namespace ex1
{
    class Program
    {
        //todo: https://docs.microsoft.com/zh-tw/dotnet/csharp/language-reference/operators/increment-operator
        static void Main(string[] args)
        {

          ex1_1();
          ex1_2();
          ex1_3();
        }

        public static void ex1_1()
        {
            int i =10,K;
            K=i++;
            Console.WriteLine(K.ToString());
        }
        public static void ex1_2()
        {
            int i=10,k;
            k=++i;
            Console.WriteLine(k.ToString());
        }
        public static void ex1_3()
        {
            int i,j,k;
            i=j=10;
            k=++i*5;
            Console.WriteLine($"k={k}");
            j=k++*2;
            Console.WriteLine($"j={j}");
        }
    }
}
