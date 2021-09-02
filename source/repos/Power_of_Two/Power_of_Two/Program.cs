using System;

namespace Power_of_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            double num, result = 0;
            Console.Write("Enter The Number : ");
            num = Convert.ToInt32(Console.ReadLine());

            for(int i=1;i<=num;i++)
            {
                result = (Math.Pow(2,i));
            }
            Console.WriteLine("The Power of {0} to the base 2 is : {1}", num, result);
        }
    }
}
