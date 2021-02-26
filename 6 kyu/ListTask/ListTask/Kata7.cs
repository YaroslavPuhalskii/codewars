using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
A Narcissistic Number is a positive number which is the sum of its own digits,
each raised to the power of the number of digits in a given base. In this Kata,
we will restrict ourselves to decimal (base 10).
For example, take 153 (3 digits), which is narcisstic:
    1^3 + 5^3 + 3^3 = 1 + 125 + 27 = 153
and 1652 (4 digits), which isn't:

    1^4 + 6^4 + 5^4 + 2^4 = 1 + 1296 + 625 + 16 = 1938
The Challenge:

Your code must return true or false depending upon whether the given number
is a Narcissistic number in base 10.
Error checking for text strings or other invalid inputs is not required,
only valid positive non-zero integers will be passed into the function.
*/
namespace ListTask
{
    public class Kata7
    {
        public static bool Narcissistic(int value)
        {
            Stack<int> list = new Stack<int>();
            int q = value;
            while(value>0)
            {
                var b = value % 10;
                value /= 10;
                list.Push(b);
            }
            double sum = 0;
            foreach(var p in list)
            {
                sum += Math.Pow(p, list.Count());
            }
            return sum == q ? true : false;
        }
    }
}
