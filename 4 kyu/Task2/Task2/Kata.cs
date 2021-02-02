using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Kata
    {
        public static string sumStrings(string a, string b)
        {
            CultureInfo culture;
            String qqq = null;
            double a1 = 0; double b1 = 0; double sum = 0;
            if (a != null && a != "")
            {
                a1 = Convert.ToDouble(a);
            }
            else { a = "0"; a1 = Convert.ToDouble(a); }

            if (b != null && b != "")
            {
                b1 = Convert.ToDouble(b);
            }
            else { b = "0"; b1 = Convert.ToDouble(b); }

            sum = a1 + b1;
            Console.WriteLine(sum);
            culture = CultureInfo.CreateSpecificCulture("en-CA");
            Console.WriteLine(sum.ToString(qqq, culture));
            Console.WriteLine("{0:F3}", sum);

            //var m = (sum == 0) ? 1 : (int)Math.Ceiling(Math.Log10(Math.Abs(sum) + 0.5));
            //List<int> list = new List<int>();
            //for (int i = 0; i < m; i++)
            //{
            //    int q = (int)sum % 10;
            //    list.Add(q);
            //    sum = sum / 10;

            //}
            //list.Reverse();
            //String ex = String.Join("", list);
            //foreach(var p in list)
            //{
            //    Console.WriteLine(p);
            //}
            Console.WriteLine(qqq);
            return qqq;
        }
    }
}
