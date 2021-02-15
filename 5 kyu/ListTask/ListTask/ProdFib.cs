using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListTask
{
    public class ProdFib
    {
        public static ulong[] productFib(ulong prod)
        {
            ulong prev = 0;
            ulong curr = 1;
            ulong multiplied = prev * curr;

            while (multiplied < prod)
            {
                ulong temp = curr;
                curr += prev;
                prev = temp;
                multiplied = prev * curr;
            }
            return new ulong[] { prev, curr, (ulong)(multiplied == prod ? 1 : 0) };            
        }
    }
}
