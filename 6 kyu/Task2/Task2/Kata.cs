using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public static class Kata
    {
        public static string ExpandedForm(long num)
        {
            var str = num.ToString();
            for(int i = 0; i< str.Length; i++)
            {
                Console.WriteLine(str[i]);
            }
            throw new NotImplementedException();
        }
    }
}
