using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListTask
{
    public class Line
    {
        public static string WhoIsNext(string[] names, long n)
        {
            long multiplicator = 1;
            var l = names.Length;
            while(n>multiplicator* l)
            {
                n -= l * multiplicator;
                multiplicator *= 2;
            }
            var m = (n - 1) / multiplicator;
            return names[m];
        }
    }
}
