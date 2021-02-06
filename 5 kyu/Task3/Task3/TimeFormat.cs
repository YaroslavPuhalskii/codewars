using System;
using System.Runtime;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Task3
{
    public static class TimeFormat
    {
        public static string GetReadableTime(int seconds)
        {
            String str = null;
            int a = seconds / 3600; String a1 = a < 10 ? "0"+a.ToString() : a.ToString();
            int b = (seconds - (a * 3600))/60; String b1 = b < 10 ? "0" + b.ToString() : b.ToString();
            int c = seconds - (a * 3600) - (b * 60); String c1 = c < 10 ? "0" + c.ToString() : c.ToString();
            if (a > 99) { str = "99:59:59"; }
            else { str = a1+":" + b1+":" + c1; }
            
            return str;
        }
    }
}
