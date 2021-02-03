using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Kata
    {
        public static string PigIt(string str)
        {
            String result = null;
            var words = str.Split(new char[] { ' '});
            List<string> str1 = new List<string>();
            string ay = "ay";

            foreach(var c in words)
            {
                var p = c.First() + ay;
                str1.Add(p);
                var q =c.Remove(0,1);
                result = result + q.ToString() + p;
            }
            Console.WriteLine(result);
            return result;
        }
    }
}
