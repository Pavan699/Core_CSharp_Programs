using System;

namespace Leap_Year
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;
            Console.Write("Enter the Year in YYYY format : ");
            year = Convert.ToInt32(Console.ReadLine());

            if((year % 4) == 0)
            {
                Console.WriteLine("Year {0} is a Leap-Year.", year);
            }
            else
            {
                Console.WriteLine("Year {0} is Not a Leap-Year.", year);
            }
        }
    }
}
