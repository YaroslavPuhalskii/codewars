using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListTask
{
    public class Number
    {
        public static int DigitalRoot(long n)
        {
            var p = n % 9;
            return (p==0 && n>0)? 9 : (int)p; 
            // Your awesome code here!
        }
    }
}
