using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Your goal in this kata is to implement a difference function, which subtracts one
list from another and returns the result.

It should remove all values from list a, which are present in list b.
Kata.ArrayDiff(new int[] {1, 2}, new int[] {1}) => new int[] {2}
*/
namespace ListTask
{
    public class Kata2
    {
        public static int[] ArrayDiff(int[] a, int[] b)
        {
            var hash = new HashSet<int>(b);
            return a.Where(x => !hash.Contains(x)).ToArray();
        }
    }
}
