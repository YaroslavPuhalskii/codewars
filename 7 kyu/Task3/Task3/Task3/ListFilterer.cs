using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class ListFilterer
    {
        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            var c = new List<int>();

            foreach(object i in listOfItems)
            {
                if(i is Int32)
                {
                    c.Add((int)i);
                }
            }
            return c;
        }
    }
}
