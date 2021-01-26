using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class TwoToOne
    {
        public string Longest(string s1, string s2)
        {
            String s3 = s1 + s2;

            var c = s3.Distinct().OrderBy(x => x).ToArray();
            string s4 = string.Concat(c);

            return s4;
        }
    }
}
