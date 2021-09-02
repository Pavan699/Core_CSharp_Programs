using System;

namespace Prime_Factor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program For Prime Factor");
            int num;
            Console.Write("Enter The Number To Find Prime factors : ");
            num = Convert.ToInt32(Console.ReadLine());

            if(num == 0 || num == 1)
            {
                Console.WriteLine("There are no Prime factors for 0 & 1");
            }
            while((num % 2) == 0)
            {
                num = num / 2;
                Console.Write("2 ");
            }
            for(int i=3;i<=num;i=i+2)
            {
                while ((num % i) == 0)
                {
                    num = num / i;
                    Console.Write("{0} ",i);
                }
            }
        }
    }
}
