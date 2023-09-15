using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] inputArray = input.ToCharArray();
            int output = 0;

            for (int i = 0; i < inputArray.Length; i++)
            {
                inputArray[i] = (char)(inputArray[i] - '0');
                output = output + inputArray[i];
            }

            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
