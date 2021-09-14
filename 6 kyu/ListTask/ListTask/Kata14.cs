using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListTask
{
    public class Kata14
    {
        public static int[] SortByBit(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    int first = Convert.ToString(array[i], 2).Replace("0", "").Count();
                    int second = Convert.ToString(array[j], 2).Replace("0", "").Count();
                    if (first < second || (first == second && array[j] > array[i]))
                    {
                        int a = array[i];
                        array[i] = array[j];
                        array[j] = a;
                    }
                }
            }
            var check = array.Reverse().ToArray();
            return array.Reverse().ToArray();
        }
    }
}
