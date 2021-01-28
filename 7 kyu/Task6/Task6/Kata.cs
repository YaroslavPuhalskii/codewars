using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    public class Kata
    {
        public int FindShort(string s)
        {
            string[] mass = s.Split(',', ' ');
            string slovo = mass[0];
            for (int i=0;  i< mass.Length-1;i++)
            {
                if(mass[i].Length > mass[i+1].Length)
                {
                    if(slovo.Length> mass[i+1].Length)
                    {
                        slovo = mass[i + 1];
                    }
                }
            }
            int b = slovo.Length;
            return b;
        }
    }
}
