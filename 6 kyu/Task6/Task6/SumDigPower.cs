using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    public class SumDigPower
    {
        public static long[] SumDigPow(long a, long b)
        {
            List<long> list = new List<long>();
            List<long> list2 = new List<long>();
            int stepen = 1; int i = 0;
            do
            {
                list.Add(a);
                a++;
            }
            while (a <= b);

            foreach(long p in list)
            {
                var sum = Convert.ToInt64(p.ToString()
                    .Select(s => Math.Pow(int.Parse(s.ToString()), stepen++))
                    .Sum());
                stepen = 1;
                if(p == sum)
                {
                    list2.Add(p);
                }
            }
            long[] mass = new long[list2.Count];
            foreach (long p in list2)
            {
                mass[i] = p;
                i++;
                Console.WriteLine(p);
            }
            return mass;
        }
    }
}
