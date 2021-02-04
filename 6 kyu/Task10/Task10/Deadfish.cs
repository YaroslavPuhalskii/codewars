using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    public class Deadfish
    {
        public static int[] Parse(string data)
        {
            List<char> list = new List<char>();
            List<int> array = new List<int>();
            list.AddRange(data);
            int x = 0;           
            
            foreach(var p in list)
            {
                switch(p)
                {
                    case 'i':
                        {
                            x++;  
                            break;
                        }
                    case 'd':
                        {
                            x--;
                            break;
                        }
                    case 's':
                        {
                            x = x * x;
                            break;
                        }
                    case 'o':
                        {
                            array.Add(x);
                            break;
                        }
                }
            }


            return array.ToArray();
        }
    }
}
