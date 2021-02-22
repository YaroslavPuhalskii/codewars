using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListTask
{
    public static class Kata4
    {
        public static string Order(string words)
        {
            Console.WriteLine(words);
            var b = words.Split(' '); int i = 1;
            List<string> list = new List<string>();
            if (b.Count() != 0)
            {
                while (i <= b.Count())
                {
                    var c = b.Where(x => x.Contains(i.ToString())).First().ToString();
                    list.Add(c);
                    i++;
                }
            }
            else list.Add("");
            Console.WriteLine(String.Join(" ", list));
            return String.Join(" ", list);
        }
    }
}
