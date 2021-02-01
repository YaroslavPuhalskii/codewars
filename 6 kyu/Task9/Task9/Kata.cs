using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    public class Kata
    {
        public static int DuplicateCount(string str)
        {
            int count1 = 0;
            string str1 = str.ToLower();      

            foreach (var letter in str1.ToLower().Distinct().ToArray())
            {
                var count = str1.Count(chr => chr == letter);
                if(count>1)
                {
                    count1++;
                }
            }
            return count1;
        }
    }
}
