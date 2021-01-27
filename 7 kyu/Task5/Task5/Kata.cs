using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class Kata
    {
        public string GetMiddle(string s)
        {
            int c = s.Count();
            int b =  c / 2;
            if (c % 2 == 1)
            { 
                return s.Substring(b,1);
            }
            else 
            { 
                return s.Substring(b-1,2);
            } 
        }
    }
}
