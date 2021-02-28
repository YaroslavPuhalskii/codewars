using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class SnailSolution
    {
        public static int[] Snail(int[][] array)
        {

            int[] result = new int[array.Length * array.Length];
            if (array.Length == 1)
                return array[0];

            int e = 0;
            int rs = 0, re = array.Length - 1, cs = 0, ce = array.Length - 1;

            for (int i = 0; i < array.Length / 2; i++)
            {
                for (int r = rs; r <= re; r++)
                {
                    result[e++] = array[cs][r];
                }
                cs++;
                for (int c = cs; c <= ce; c++)
                {
                    result[e++] = array[c][re];
                }
                re--;
                for (int r = re; r >= rs; r--)
                {
                    result[e++] = array[ce][r];
                }
                ce--;
                for (int c = ce; c >= cs; c--)
                {
                    result[e++] = array[c][rs];
                }
                rs++;
            }
            if (array.Length % 2 != 0)
            {
                result[e] = array[rs][cs];
            }

            return result;
        }




























        //public static List<int> list = new List<int>();
        //public static int[] Snail(int[][] array)
        //{
        //    int[] result = rigth(array, 0 , array[0].Length).ToArray();
        //    return result;
        //}

        //private static List<int> rigth(int[][] array, int start, int end)
        //{
        //    for(int i = start; i< end; i++)
        //    {
        //        list.Add(array[start][i]);
        //    }
        //    if(array[0].Length * array[0].Length == list.Count)
        //    {
        //        return list;
        //    }
        //    return bot(array, start + 1, array[0].Length-1);
        //}

        //private static List<int> bot(int[][] array, int start, int end)
        //{
        //    for(int i = start; i <= end; i++)
        //    {
        //        list.Add(array[i][end]);
        //    }
        //    if (array[0].Length * array[0].Length == list.Count)
        //    {
        //        return list;
        //    }
        //    return left(array, end, start - 1);
        //}

        //private static List<int> left(int[][] array, int start, int end)
        //{
        //    for (int i = start - 1; i >= end; i--)
        //    {
        //        list.Add(array[start][i]);
        //    }
        //    if (array[0].Length * array[0].Length == list.Count)
        //    {
        //        return list;
        //    }
        //    return top(array, end, array[0].Length - end - 1);
        //}

        //private static List<int> top(int[][] array, int start, int end)
        //{
        //    for (int i = end - 1; i > start; i--)
        //    {
        //        list.Add(array[i][start]);
        //    }
        //    if (array[0].Length * array[0].Length != list.Count)
        //    {
        //        return rigth(array, array[0].Length - end, array[0].Length - start - 1);
        //    }
        //    else
        //    {
        //        return list;
        //    }
        //}
    }
}
