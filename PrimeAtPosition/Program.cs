﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeAtPosition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] primes = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };
            string input = Console.ReadLine();
            int intInput = Int32.Parse(input) - 1;
            Console.WriteLine(primes[intInput]);
            Console.ReadLine();
        }
    }
}
