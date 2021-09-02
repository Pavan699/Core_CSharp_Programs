using System;

namespace Quotient_Remainder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quotient and Remainder Program");
            long Number, divisor, remainder, quotient;
            Console.Write("Enter the Number for Division : ");
            Number = Convert.ToInt64(Console.ReadLine());
            Console.Write("Enter the divisor for Division : ");
            divisor = Convert.ToInt64(Console.ReadLine());

            //by using math method
            Console.WriteLine("By using Math.DivRem() Method : ");
            quotient = Math.DivRem(Number, divisor, out remainder);
            Console.WriteLine("Quotient of the Division is : " + quotient);
            Console.WriteLine("Remainder of the Division is : " + remainder);

            //by logic 
            Console.WriteLine("By using logic : ");
            quotient = Number / divisor;
            Console.WriteLine("Quotient of the Division is : " + quotient);
            remainder = Number % divisor;
            Console.WriteLine("Remainder of the Division is : " + remainder);
        }
    }
}
