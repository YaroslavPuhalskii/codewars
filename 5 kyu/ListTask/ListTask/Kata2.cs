using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
/*
Write a program that will calculate the number of trailing zeros in a factorial of a given number.
N! = 1 * 2 * 3 * ... * N

Be careful 1000! has 2568 digits...
Examples
zeros(6) = 1
# 6! = 1 * 2 * 3 * 4 * 5 * 6 = 720 --> 1 trailing zero
zeros(12) = 2
# 12! = 479001600 --> 2 trailing zeros
Hint: You're not meant to calculate the factorial. Find another way to find the number of zeros.
*/
namespace ListTask
{
    public static class Kata2
    {
        public static int TrailingZeros(int n)
        {
            int res = 0;
            while(n>0)
            {
                n /= 5;
                res += n;
            }
            Console.WriteLine(res);
            return res;
        }
    }
}
