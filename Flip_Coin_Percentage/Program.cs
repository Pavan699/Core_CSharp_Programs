using System;

namespace Flip_Coin_Percentage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Flip The Coin and Calculate the Percentage");
            Random r = new Random();
            int count_tail = 0, count_head = 0;

            for (int i = 1; i <= 10; i++)
            {
                double coin = r.NextDouble();
                if (coin < 0.5)
                {
                    Console.WriteLine(coin+" Tail");
                    count_tail += 1;
                }
                else
                {
                    Console.WriteLine(coin+" Head");
                    count_head += 1;
                }
            }
            Console.WriteLine("The Ratio of Tail:Head is : ({0}:{1})", count_tail, count_head);
            Console.WriteLine("Percentage of Tail is : {0}%", count_tail * 10);
            Console.WriteLine("Percentage of Head is : {0}%", count_head * 10);
        }
    }
}
