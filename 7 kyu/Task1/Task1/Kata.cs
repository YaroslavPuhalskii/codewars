using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Kata
    {
        public int Disemvowel(int n)
        {
            List<int> m = new List<int>();
            while (n != 0)
            {
                int i = 10;
                int d = n % i;
                int q = d * d;

                m.Add(q);
                n = (int)n / i;

            }
            m.Reverse();
            var g = string.Join("", m);
            int result = Int32.Parse(g);
            Console.WriteLine(result);

            return result;
        }
    }
}
