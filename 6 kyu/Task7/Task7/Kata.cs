using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    public class Kata
    {
        public static long QueueTime(int[] customers, int n)
        {
            var checkout = new int[n];

            foreach (var customer in customers)
            {
                checkout[Array.IndexOf(checkout, checkout.Min())] += customer;
            }

            return checkout.Max();
        }
    }
}
