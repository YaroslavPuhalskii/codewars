using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListTask
{
    public class Josephus
    {
        public static List<object> JosephusPermutation(List<object> items, int k)
        {

            var res = new List<object>();
            int count = items.Count();
            int i = 0;
            while (count > 0)
            {
                i = (i + k - 1) % items.Count();
                res.Add(items[i]);
                items.RemoveAt(i);
                count--;
            }          
            foreach(var p in res)
            {
                Console.WriteLine(p);
            }
            return res;
        }
    }
}
