using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListTask
{
    class Program
    {
        static void Main(string[] args)
        {
            String start = "10.0.0.0"; String end = "10.0.1.0";
            CountIPAddresses.IpsBetween(start, end);
            Console.ReadLine();
        }
    }
}
