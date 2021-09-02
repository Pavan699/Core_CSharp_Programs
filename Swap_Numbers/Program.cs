using System;

namespace Swap_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Swapping of Two Numbers Program");
            int num1, num2,temp;
            Console.Write("Enter The 1st number : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter The 2st number : ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before Swapping Number_One is {0} And Number_Two is {1}", num1, num2);

            //Swapping
            temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine(" After Swapping Number_One is {0} And Number_Two is {1}", num1, num2);
        }
    }
}
