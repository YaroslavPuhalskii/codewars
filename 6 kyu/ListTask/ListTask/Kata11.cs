using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListTask
{
    public class Kata11 
    {
        public static string BreakCamelCase(string str)
        {
            var result = string.Empty;
            for (int i = 0; i < str.Length; i++)
            {
                if ((int)str[i] >= 60 && (int)str[i] <= 90)
                {
                    result += " ";
                }

                result += str[i];
            }
            return result;
        }
    }
}
