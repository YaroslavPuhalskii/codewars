using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Task
You will be given an array of numbers. You have to sort the odd numbers in ascending
order while leaving the even numbers at their original positions.

Examples

[7, 1]  =>  [1, 7]
[5, 8, 6, 3, 4]  =>  [3, 8, 6, 5, 4]
[9, 8, 7, 6, 5, 4, 3, 2, 1, 0]  =>  [1, 8, 3, 6, 5, 4, 7, 2, 9, 0]
*/
namespace ListTask
{
    public class Kata6
    {
        public static int[] SortArray(int[] array)
        {
            for(int i =0; i<array.Length; i++)
            {
                if(array[i] %2 ==0)
                { continue; }
                for(int j = i+1; j< array.Length; j++)
                {
                    if(array[j] % 2 != 0)
                    {
                        if(array[i] > array[j])
                        {
                            int temp = array[i];
                            array[i] = array[j];
                            array[j] = temp;
                        }
                    }
                }
            }
            return array;
        }
    }
}
