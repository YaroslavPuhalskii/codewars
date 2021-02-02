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
            var m = (num == 0) ? 1 : (int)Math.Ceiling(Math.Log10(Math.Abs(num) + 0.5));
            var q = num.ToString().ToCharArray().Select(x => (int)(x -'0'));
            q.Reverse();
            long stepen = Convert.ToInt64(Math.Pow(10, m - 1));
            List<string> mass = new List<string>();
            foreach (int p in q)
            {

                if (p != 0 && stepen != 1)
                {
                    
                    var str = (p * stepen).ToString();
                    stepen = stepen / 10;
                    mass.Add(str);
                }
                else if (p == 0) { stepen = stepen / 10; }
                else if (stepen == 1) { mass.Add(p.ToString()); }

            }
            string expForm = String.Join(" + ", mass);
            return expForm;
        }
    }
}

