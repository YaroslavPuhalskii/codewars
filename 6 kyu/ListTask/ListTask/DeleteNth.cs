using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListTask
{
    public class DeleteNth
    {
        public static int[] DeleteNth1(int[] arr, int q)
        {
            int[] result = null;
            Dictionary<int, int> dic = new Dictionary<int, int>();
            var c = arr.GroupBy(x => x);
            foreach(var k in c)
            {
                Console.WriteLine(k.Key +"("+ k.Count()+")");
                dic.Add(k.Key, k.Count());
            }

            for(int i = 0; i < arr.Length; i++)
            {
               // if(arr[i]=)
            }
            return result;
        }
    }
}
