using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Kata
    {
        public static string sumStrings(string a, string b)
        {
            var masa = a.ToArray();
            masa.Reverse();
            Console.WriteLine(masa);
            var masb = b.ToArray();
            masb.Reverse();
            Console.WriteLine(masb);
            int suma = masa.Count();
            int sumb = masb.Count();
            var ressum = suma>sumb ? suma : sumb;

            int temp = 0; int x1 = 0; int x2 = 0;
            List<int> list = new List<int>();

            for (int i = 0; i < ressum; i++)
            {

                if (i<= suma)
                {
                    x1 = int.Parse(masa[i].ToString());

                }
                if (i<=sumb-1)
                {
                    x2 = int.Parse(masb[i].ToString());
                }
                list.Add((x1 + x2 + temp) % 10);
                temp = (x1 + x2) / 10;
            }

            var result = list.ToArray();
            result.Reverse();
            var sum = String.Join("", result);
            Console.WriteLine(sum);
            return "";







            return "";


            //float a1 = 0f; float b1 = 0f; float sum = 0f;
            //if (a != null && a != "")
            //{
            //    a1 = Convert.ToSingle(a);
            //}
            //else { a = "0"; a1 = Convert.ToSingle(a); }

            //if (b != null && b != "")
            //{
            //    b1 = Convert.ToSingle(b);
            //}
            //else { b= "0"; b1 = Convert.ToSingle(b); }
            
            //sum = a1 + b1;
            //var m = (sum == 0) ? 1 : (int)Math.Ceiling(Math.Log10(Math.Abs(sum) + 0.5));
            //List<int> list = new List<int>();
            //for(int i = 0; i < sum.ToString().Length; i++)
            //{
            //     int k = sum/ 10;
            //}
            //Console.WriteLine(sum);
            //return sum.ToString();
        }
    }
}
