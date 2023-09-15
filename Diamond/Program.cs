using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] stars = { "    *    ", "   ***   ", "  *****  ", " ******* ", "*********" };

            for (int z = 0; z < 5; z++)
            {
                Console.WriteLine(stars[z]);
            }
            for (int z = 3; z > -1; z--)
            {
                Console.WriteLine(stars[z]);
            }
            Console.ReadLine();
        }
    }
}
