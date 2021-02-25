using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Implement the function unique_in_order which takes as argument a sequence
and returns a list of items without any elements with the same value next
to each other and preserving the original order of elements.
For example:

uniqueInOrder("AAAABBBCCDAABBB") == {'A', 'B', 'C', 'D', 'A', 'B'}
uniqueInOrder("ABBCcAD")         == {'A', 'B', 'C', 'c', 'A', 'D'}
uniqueInOrder([1,2,2,3,3])       == {1,2,3}
*/
namespace ListTask
{
    public static class Kata5
    {
        public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
        {
            List<T> result = new List<T>(); 
            foreach(T p in iterable)
            {
                if(!result.Contains(p))
                { result.Add(p); }
                else if (result.LastIndexOf(p) != result.Count - 1)
                { result.Add(p); }                    
            }
            return result;        
        }
    }
}
