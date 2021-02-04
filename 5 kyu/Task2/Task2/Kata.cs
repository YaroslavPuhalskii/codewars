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
            var words = str.Split(new char[] { ' ' });
            List<string> str1 = new List<string>();
            string ay = "ay";
            foreach(var c in words)
            {
                if (c != "!")
                {
                    var p = c.First() + ay;
                    str1.Add(p);
                    var q = c.Remove(0, 1);
                    result = result + q.ToString() + p + " ";
                }
                else { var p = c.First().ToString();
                    str1.Add(p);
                    var q = c.Remove(0, 1);
                    result = result + q.ToString() + p + " ";
                }                
            }
            result = result.Remove(result.Length-1);
            return result;
            dksaljfghksd;ljfaklwkwfka;lf
                awfaw
                faw
                faw
                f
                waf
                aw
                f
                wa
                f
                wa
                f
                awfkawlgjkalwg
                agwg;agwgjga
                ga
                gjajg;ajg;ajg
                ajw;ldld
                wqdq
                dqwl;dmq;lwf
                qwf
        }
    }
}
