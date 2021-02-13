using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
The maximum sum subarray problem consists in finding the maximum sum of a contiguous
subsequence in an array or list of integers:

maxSequence [-2, 1, -3, 4, -1, 2, 1, -5, 4]
-- should be 6: [4, -1, 2, 1]
Easy case is when the list is made up of only positive numbers and the maximum sum
is the sum of the whole array. If the list is made up of only negative numbers, return 0 instead.

Empty list is considered to have zero greatest sum. Note that the empty list
or array is also a valid sublist/subarray.
*/
namespace ListTask
{
    public static class Kata5
    {
        public static int MaxSequence(int[] arr)
        {
            int result = 0;
            if (arr.Count() > 0)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    int SumArr = 0;
                    for (int j = i; j < arr.Length; j++)
                    {
                        SumArr += arr[j];
                        result = result < SumArr ? SumArr : result;
                    }
                }
            }
            Console.WriteLine(result);
            return result;
        }
    }
}
