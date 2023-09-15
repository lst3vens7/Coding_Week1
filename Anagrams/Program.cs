using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagrams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "parts", "traps", "arts", "rats", "starts", "tarts", "rat", "art", "tar", "tars", "stars", "stray" };

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length == 4 & (words[i].Contains("s")) & (words[i].Contains("t")) & (words[i].Contains("a")) & (words[i].Contains("r")))
                {
                }
                else
                {
                    words[i] = string.Empty;
                }
            }

            Console.Write("Anagrams for star are: ");
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] != string.Empty)
                {
                    Console.Write(words[i] + " ");
                }

            }
            Console.ReadLine();
        }
    }
}
