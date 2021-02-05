using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12
{
    public class Line
    {
        public static string Tickets(int[] peopleInLine)
        {
            String str = "YES";
            int count1 = 0; int count2 = 0;
            for(int i = 0; i< peopleInLine.Length; i++)
            {
                if(peopleInLine[i] == 25 && str != "NO" )
                {
                    count1++;
                }
                if (peopleInLine[i] == 50 && count1 > 0 && str != "NO")
                {
                    count1--;
                    count2++;
                }
                else if (peopleInLine[i] == 50 && count1 == 0) { str = "NO"; }
                if (peopleInLine[i] == 100 && str != "NO")
                {
                    if (count2 > 0 && count1 > 0) { count2--; count1--; }
                    else if (count1 > 2) { count1--; count1--; count1--; }
                    else { str = "NO"; }
                    
                }                
            }
            return str;
        }
    }
}
