using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Write a function that takes an integer as input, and returns the number of bits that are equal to one
        in the binary representation of that number. You can guarantee that input is non-negative.
Example: 
The binary representation of 1234 is 10011010010, so the function should return 5 in this case.  
 */

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Kata.CountBits(20);
            Console.ReadLine();
        }
    }
}
