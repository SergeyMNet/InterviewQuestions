using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Palindrome " + IsPalindrome("Palindrome"));
            Console.WriteLine("12121 " + IsPalindrome("12121"));

            Console.ReadKey();
        }

        static bool IsPalindrome(string str)
        {
            var result = false;

            for (int i = 0, j = str.Length-1; i < str.Length / 2; i++, j--)
            {
                if(str[i] != str[j])
                {
                    result = false;
                    break;
                }
                else
                {
                    result = true;
                }
            }

            return result;
        }
    }
}
