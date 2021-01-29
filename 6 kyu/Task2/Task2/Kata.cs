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
            int k = 0;
            var m = (num == 0) ? 1 : (int)Math.Ceiling(Math.Log10(Math.Abs(num) + 0.5));
            List<int> array = new List<int>();
            for (int i = 0; i < m; i++)
            {
                k = (int)num % 10;
                array.Add(k);
                num /= 10;
            }
            array.Reverse();
            int stepen = Convert.ToInt32(Math.Pow(10, m - 1));
            foreach (int p in array)
            {

                if (p != 0 && stepen != 1)
                {
                    
                    var str = (p * stepen).ToString();
                    stepen = stepen / 10;
                    Console.Write(str + " + ");
                    return "";
                }
                else if (p == 0) { stepen = stepen / 10; }
                else if (stepen == 1) { Console.Write(p);return " "; }
                return " ";

            }
            Console.WriteLine("---------------------");

        }
    }
}

