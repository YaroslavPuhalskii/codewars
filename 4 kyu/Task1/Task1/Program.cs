using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[3][];
            arr[0] = new int[] {1,2,3 };
            arr[1] = new int[] {4,5,6 };
            arr[2] = new int[] {7,8,9 };
            SnailSolution.Snail(arr);
        }
    }
}
