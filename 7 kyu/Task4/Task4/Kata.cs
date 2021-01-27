using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public  class Kata
    {
        public  bool XO(string input)
        {
            var c1 = new List<char>();
            var c2 = new List<char>();
            foreach (char c in input)
            {
                if (c == 'x' || c == 'X') { c1.Add(c); }
                else if (c == 'o' || c == 'O') { c2.Add(c); }
            }
            if (c1.Count == c2.Count || (c1.Count == 0 && c2.Count == 0)) { return true; }
            else { return false; }
        }
    }
}
