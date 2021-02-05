using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13
{
    public class Kata
    {
        public static string CreatePhoneNumber(int[] numbers)
        {           
            string str1 = null; string str2=null; string str3=null;
            for(int i = 0; i< numbers.Length; i++)
            {
                if(i<3)
                {
                    str1 = str1 + numbers[i]; 
                }
                if(i>2 && i<6)
                {
                    str2 = str2 + numbers[i];
                }
                if (i > 5)
                {
                    str3 = str3 + numbers[i];
                }
            }
            String str = "(" + str1 + ")" + " " + str2 + "-" + str3;
            return str;
        }
    }
}
