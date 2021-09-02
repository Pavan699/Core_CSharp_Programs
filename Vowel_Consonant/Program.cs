using System;

namespace Vowel_Consonant
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vowel and Consonants in a String");
            string str;
            Console.Write("Enter The String to Check vowels and consonants :");
            str = Console.ReadLine();
            
            for (int i = 0; i <= str.Length-1; i++ )
            {
                if (str[i] == 'a'||str[i] == 'e'||str[i] == 'i'||str[i] == 'o'||str[i] == 'u' || str[i] == 'A' || str[i] == 'E' || str[i] == 'I' || str[i] == 'O' || str[i] == 'U')
                {
                    Console.WriteLine(str[i] + " is a vowel");
                }
                else
                {
                    Console.WriteLine(str[i] + " is a consonant");
                }
            }
        }
    }
}
