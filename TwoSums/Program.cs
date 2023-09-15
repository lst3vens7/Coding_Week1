using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = { 3, 1, 5, 7, 5, 9 };
            int goal = 10;

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input.Length; j++)
                {
                    if (i != j & input[i] + input[j] == goal)
                    {
                        Console.WriteLine("The goal can be found adding the values at postion {0} and {1}", i, j);
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                }
            }
        }
    }
}
