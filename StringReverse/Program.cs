using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "hello world";
            char[] inputArray = input.ToCharArray();
            Array.Reverse(inputArray);
            string output = new string(inputArray);
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
