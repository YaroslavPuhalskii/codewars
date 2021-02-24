using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Create a function that takes a positive integer and returns the next bigger number that
can be formed by rearranging its digits. For example:

12 ==> 21
513 ==> 531
2017 ==> 2071
nextBigger(num: 12)   // returns 21
nextBigger(num: 513)  // returns 531
nextBigger(num: 2017) // returns 2071
If the digits can't be rearranged to form a bigger number, return -1 (or nil in Swift):

9 ==> -1
111 ==> -1
531 ==> -1
nextBigger(num: 9)   // returns nil
nextBigger(num: 111) // returns nil
nextBigger(num: 531) // returns nil
*/
namespace ListTask
{
    public class Kata
    {
        public static long NextBiggerNumber(long n)
        {
            var list = new List<int>(); int b = 0; int count = 0;
            var m = n.ToString().ToCharArray().Reverse().Select(x => (int)(x - '0'));
            foreach (var p in m)
            {
                if (p < b)
                {
                    list.Add(p);
                    b = p;
                    m = m.Reverse().Take(m.Count() - count-1);
                    break;
                }
                list.Add(p);
                b = p;
                count++;
            }
            list.Reverse();
            return Complete(list, m, b);
        }

        private static long Complete(List<int> list, IEnumerable<int> m, int b)
        {
            var chislo = list.Where(x => x > b).Min();
            int index = list.IndexOf(list.Where(x => x == chislo).FirstOrDefault());
            list[index] = b;
            list[0] = chislo;
            list.Skip(1).OrderBy(x => x);
            return Convert.ToInt64(String.Join("", m) + chislo.ToString()+String.Join("", list.Skip(1).OrderBy(x => x)));
        }
    }
}
