using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Kata
    {
        public static int GetUnique(IEnumerable<int> numbers)
        {
            int i=0;
            var a = numbers.OrderBy(x => x).Take(3).ToArray();
            var b = numbers.OrderByDescending(x => x).Take(1).ToArray();
            if (a[0] == a[1])
            {
                i = b[0];
            }
            else if (a[0] != a[1]) { i = a[0]; }
            return i;
        }
    }
}
