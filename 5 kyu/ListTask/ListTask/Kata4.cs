using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
What is an anagram? Well, two words are anagrams of each other if they both contain the same letters.
For example:

'abba' & 'baab' == true
'abba' & 'bbaa' == true
'abba' & 'abbba' == false
'abba' & 'abca' == false

Write a function that will find all the anagrams of a word from a list.
You will be given two inputs a word and an array with words.
You should return an array of all the anagrams or an empty array if there are none. For example:

anagrams('abba', ['aabb', 'abcd', 'bbaa', 'dada']) => ['aabb', 'bbaa']
anagrams('racer', ['crazer', 'carer', 'racar', 'caers', 'racer']) => ['carer', 'racer']
anagrams('laser', ['lazing', 'lazy',  'lacer']) => []
*/
namespace ListTask
{
    public static class Kata4
    {
        public static List<string> Anagrams(string word, List<string> words)
        {
            var charWord = word.ToList<char>();
            charWord.Sort();
            string stringWord = new string(charWord.ToArray()); 
            List<string> strFinally = new List<string>();

            foreach (string item in words)
            {
                List<char> chars = new List<char>(item.ToCharArray());
                chars.Sort();
                string outString = new string(chars.ToArray());
                if (stringWord == outString) { strFinally.Add(item); }                
            }         
            return strFinally;
        }
    }
}
