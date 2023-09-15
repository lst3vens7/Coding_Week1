using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace longestSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sequence = { 1, 2, 1, 1, 0, 3, 1, 0, 0, 2, 4, 1, 0, 0, 0, 0, 2, 1, 0, 3, 1, 0, 0, 0, 6, 1, 3, 0, 0, 0 };

            int counter = 0;
            int longest = 0;

            for (int i = 0; i < sequence.Length; i++)
            {
                if (sequence[i] == 0)
                {
                    counter = counter + 1;
                    if (counter > longest)
                    {
                        longest = counter;
                    }
                }
                else
                {
                    counter = 0;
                }
            }

            Console.WriteLine(longest);
            Console.ReadLine();
        }
    }
}
