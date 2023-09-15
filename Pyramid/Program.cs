using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int iterations = 10;

            for (int z = 0; z < iterations; z++)
            {

                for (int y = iterations - z; y > 0; y--)
                {
                    Console.Write(" ");
                }

                Console.Write("*");

                for (int x = 0; x < z; x++)
                {
                    Console.Write("**");
                }

                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
