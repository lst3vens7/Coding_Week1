using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] inputArray = input.ToCharArray();
            bool palindrome = true;

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] != inputArray[inputArray.Length - 1 - i])
                {
                    palindrome = false;
                    break;
                }
            }

            if (palindrome)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }
            Console.ReadLine();
        }
    }
}
