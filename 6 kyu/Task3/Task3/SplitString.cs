using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class SplitString
    {
        public static string[] Solution(string str)
        {
            List<String> s = new List<String>();
            string s1= null, s2, sum;
            var summ = str.Length;
            string[] str2;
            for (int i =0; i<str.Length; i++)
            {
                if(i%2 ==0)
                {
                    s1 = str[i].ToString();
                }
                if((i == (str.Length -1)) && summ%2!=0)
                {
                    s2 = "_";
                    sum = s1 + s2;
                    s.Add(sum);
                }
                if (i % 2 == 1) 
                {
                    s2 = str[i].ToString();
                    sum = s1 + s2;
                    s.Add(sum);
                }                
            }
            int l = 0;
            str2 = new string[s.Count];
            foreach (string p in s)
            {
                Console.WriteLine(p);
                str2[l] = p;
                l++;
            }

            return str2 ;
        }
    }
}
