using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CountCharacters("Hello World");
        }

        static void CountCharacters(string str)
        {
           
            Dictionary<char, int> characterCount = new Dictionary<char, int>();

            foreach(var character in str)
            {
                if(character != ' ')
                {
                    if(!characterCount.ContainsKey(character))
                    {
                        characterCount.Add(character, 1);
                    }
                    else
                    {
                        characterCount[character]++;
                    }
                }
            }
            foreach(var x in characterCount)
                Console.WriteLine(x.Key + " " + x.Value);
        }
    }
}
