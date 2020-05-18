using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = "ReverseString";
            Console.WriteLine(str);
            Console.WriteLine(ReverseString(str));

            Console.ReadKey();
        }

        static string ReverseString(string str)
        {
            var charArray = str.ToCharArray();
            for (int i = 0, j = str.Length-1; i < j; i++, j--)
            {
                charArray[i] = str[j];
                charArray[j] = str[i];
            }

            return new string(charArray);
        }
    }
}
