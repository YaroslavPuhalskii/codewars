using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Write an algorithm that takes an array and moves all of the zeros to the end,
preserving the order of the other elements.

Kata.MoveZeroes(new int[] {1, 2, 0, 1, 0, 1, 0, 3, 0, 1}) => new int[] {1, 2, 1, 1, 3, 1, 0, 0, 0, 0}
*/
namespace ListTask
{
    public class Kata
    {
        public static int[] MoveZeroes(int[] arr)
        {
            var arr1 = arr.ToList().Where(x => x == 0).Count();
            List<int> result = new List<int>();
            int b = 0;
            foreach (var p in arr)
            {
                if (p != 0) { result.Add(p); }
            }
            while (b<arr1) { result.Add(0); b++; }
            
            return result.ToArray();
        }
    }
}
