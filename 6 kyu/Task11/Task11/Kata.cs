using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    public class Kata
    {
        public static int find_it(int[] seq)
        {
            var arr = seq.ToList();
            int res = 0;
            foreach (int val in arr.Distinct())
            {
                var b = arr.Where(x => x == val).Count();
                if (b % 2 == 1) { res = val; }
            }
            Console.WriteLine(res);
            return res;
        }
    }
}
