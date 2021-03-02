using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListTask
{
    public class Kata9
    {
        public static string BreakCamelCase(string str)
        {
            String result = "";

            for (int i = 0; i < str.Length; i++)
            {
                int charStr = str[i];
                if (charStr > 64 && charStr < 91)
                {
                    result += " " + (char)charStr;
                }
                else
                {
                    result += (char)charStr;
                }
            }
            return result;

        }
    }
}
