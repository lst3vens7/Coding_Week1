using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextPrime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int number = Int32.Parse(input);


            while (true)
            {
                bool primeFound = true;
                number = number + 1;
                for (int z = 2; z < number; z++)
                {
                    if (number % z == 0)
                    {
                        primeFound = false;
                        break;
                    }
                }

                if (primeFound)
                {
                    Console.WriteLine("The next prime number is: {0}", number);
                    Console.ReadLine();
                }
            }
        }
    }
}
