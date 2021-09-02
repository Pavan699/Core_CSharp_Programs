using System;

namespace Even_Odd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to Check Even and Odd Number");
            int Num;
            Console.Write("Enter The Number : ");
            Num = Convert.ToInt32(Console.ReadLine());

            if (Num%2 == 0)
            {
                Console.WriteLine("The Number {0} is Even.", Num);
            }
            else
            {
                Console.WriteLine("The Number {0} is Odd.", Num);
            }
        }
    }
}
