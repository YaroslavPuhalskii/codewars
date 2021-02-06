using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Given a positive number n > 1 find the prime factor decomposition of n.
The result will be a string with the following form :
 "(p1**n1)(p2**n2)...(pk**nk)"
where a ** b means a to the power of b
with the p(i) in increasing order and n(i) empty if n(i) is 1.

Example: n = 86240 should return "(2**5)(5)(7**2)(11)"
*/
namespace ListTask
{
    public class PrimeDecomp
    {

        public static String factors(int lst)
        {
            List<int> list = new List<int>();
            int count = 1; String str=null;
            for (int i = 0; lst % 2 == 0; lst /= 2) { list.Add(2); }
            for(int i =3; i<=lst; )
            {
                if (lst % i == 0) { list.Add(i); lst /= i; }
                else { i += 2; }
            }
            var p = list.Count();
            for (int i = 0; i < list.Count; i++)
            {
                if (i < list.Count - 1)
                {
                    if (list[i] == list[i + 1]) { count++; }
                    if (list[i] != list[i + 1])
                    {
                        if (count > 1)
                        {
                            str = str + "(" + list[i] + "**" + count + ")";
                            count = 1;
                        }
                        else { str = str + "(" + list[i] + ")"; }
                    }
                }
                else 
                {
                    if (count > 1) { str = str + "(" + list[i] + "**" + count + ")"; }
                    else if(count ==1) { str = str + "(" + list[i] + ")"; }
                }
            }
            return str;           
        }
    }
}
