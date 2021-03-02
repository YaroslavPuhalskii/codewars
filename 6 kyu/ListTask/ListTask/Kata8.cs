using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListTask
{
    public class Kata8
    {
        public static int CountBits(int n)
        {
            String str = Convert.ToString(n, 2);
            var b = str.ToCharArray().Where(x => x=='1').Count();           
            return b;
        }
    }
}
