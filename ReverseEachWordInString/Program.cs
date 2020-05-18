using System;
using System.Collections.Generic;
using System.Text;

namespace ReverseEachWordInString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World !");
            Console.WriteLine(ReverseWords("Hello World !"));
        }

        static string ReverseWords(string str)
        {  
            StringBuilder output = new StringBuilder();  
            List<char> charlist = new List<char>();  
        
            for (int i = 0; i < str.Length; i++)  
            {  
                if (str[i] == ' ' || i == str.Length - 1)  
                {  
                    if (i == str.Length - 1)  
                        charlist.Add(str[i]);  
                    for (int j = charlist.Count - 1; j >= 0; j--)  
                        output.Append(charlist[j]);  
        
                    output.Append(' ');  
                    charlist = new List<char>();  
                }  
                else  
                    charlist.Add(str[i]);  
            }

            return output.ToString();
        }
    }
}
