using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Given an array of integers, find the one that appears an odd number of times.

There will always be only one integer that appears an odd number of times.
*/

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { -2, - 2, - 1 ,- 1,1,1,2,2,3,3,4,4,5,5,5,20,20, - 2, - 2, - 1,1,1,2,2,4,4,5,5,1,1,2,2,3,3,4,4,5,5,5,20,20,10 };
            Kata.find_it(a);
            Console.ReadLine();
        }
    }
}
