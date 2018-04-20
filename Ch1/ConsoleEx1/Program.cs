using System;

namespace home1
{
    class Program
    {
        static void Main(string[] args)
        {
          homework();
        }

        public static void homework()
        {
            string ItemName;
            int price=0;
            Console.Write("請輸入品名 :");
            ItemName=Console.ReadLine();
            Console.Write("請輸入單價 :");
            price=int.Parse(Console.ReadLine());
            Console.WriteLine($"品名 : {ItemName} , 單價 : {price.ToString()} , 這筆紀錄儲存成功");
        }
    }
}
