using System;

namespace Largest_in_three
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Largest Number in between Three Numbers Program");
            int num1, num2, num3;
            Console.Write("Enter The 1st number : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter The 2st number : ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter The 3st number : ");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("The Number {0} is Largest number.", num1);
            }
            if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("The Number {0} is Largest number.", num2);
            }
            if (num3 > num1 && num3 > num2)
            {
                Console.WriteLine("The Number {0} is Largest number.", num3);
            }
        }
    }
}
