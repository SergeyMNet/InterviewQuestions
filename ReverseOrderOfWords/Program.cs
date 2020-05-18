using System;
using System.Text;

namespace ReverseOrderOfWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World !");
            Console.WriteLine(ReverseWordOrder("Hello World !"));
            
            Console.ReadKey();
        }

        static string ReverseWordOrder(string str)  
        {  
            int i;  
            var reverseSentence = new StringBuilder();

            int Start = str.Length - 1;  
            int End = str.Length - 1;  
        
            while (Start > 0)  
            {  
                if (str[Start] == ' ')  
                {  
                    i = Start + 1;  
                    while (i <= End)  
                    {  
                        reverseSentence.Append(str[i]);  
                        i++;  
                    }  
                    reverseSentence.Append(' ');  
                    End = Start - 1;  
                }  
                Start--;  
            }

            for (i = 0; i <= End; i++)  
            {  
                reverseSentence.Append(str[i]);  
            }

            return reverseSentence.ToString();  
        }
    }
}
