using System;
using System.Collections.Generic;
using System.Linq;

namespace CountCharacterInString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(Countcharacter("Hello World!"));
        }

        static string Countcharacter(string str)
        {  
            Dictionary<char, int> characterCount = new Dictionary<char, int>();  
        
            foreach (var character in str)  
            {
                if (character != ' ')
                {
                    if (!characterCount.ContainsKey(character))
                    {
                        characterCount.Add(character, 1);
                    }
                    else  
                    {
                        characterCount[character]++;
                    }
                }  
        
            }

            return string.Join("; ", characterCount.Select(character => $"{character.Key} - {character.Value}"));
        }
    }
}
