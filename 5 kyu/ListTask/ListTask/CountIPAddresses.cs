using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Implement a function that receives two IPv4 addresses, and returns the number of addresses between
them (including the first one, excluding the last one).

All inputs will be valid IPv4 addresses in the form of strings.
The last address will always be greater than the first one.
*/
namespace ListTask
{
    public class CountIPAddresses
    {
        public static long IpsBetween(string start, string end)
        {
            
            var a = start.Split('.').ToList().Select(x => int.Parse(x));
            var b = end.Split('.').ToList().Select(x => int.Parse(x));
            var sum1 = a.ElementAt(3) 
                + a.ElementAt(2) * 256
                + a.ElementAt(1) * 256 * 256
                + a.ElementAt(0) * 256 * 256 * 256;
            var sum2 = b.ElementAt(3) 
                + b.ElementAt(2) * 256
                + b.ElementAt(1) * 256 * 256
                + b.ElementAt(0) * 256 * 256 * 256;
            long result = sum2 - sum1;
            return result;
        }
    }
}
