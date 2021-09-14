using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ListTask
{
    public class Kata13
    {
        public static ulong finance(ulong n)
        {
            ulong sum = 0;
            ulong head = 0;
            for (ulong i = 0; i <= n; i++)
            {
                for (ulong j = head; j <= head + n - i; j++)
                {
                    sum += j;
                }

                head += 2;
            }

            return sum;
        }
    }
}
