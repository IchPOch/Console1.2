using System;

namespace _1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int ch, x, y;
            Console.WriteLine("Введите трёхзначное число");
            ch = Convert.ToInt32(Console.ReadLine());
            if (ch < 100 || ch > 999) Console.WriteLine("Введённое число не трёхзнач");
            else
            {
                x = ch / 100;
                y = ch % 10;
                if (x > y)
                    Console.WriteLine("Первое больше");
                else
                    Console.WriteLine("Последнее больше");
            }
        }
    }

}
