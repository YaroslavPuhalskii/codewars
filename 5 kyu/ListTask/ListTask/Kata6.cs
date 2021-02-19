using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
You probably know the "like" system from Facebook and other pages.
People can "like" blog posts, pictures or other items. We want to create the text
that should be displayed next to such an item.

Implement a function likes :: [String] -> String, which must take in input array, 
containing the names of people who like an item. It must return the display text as shown in the examples:

Kata.Likes(new string[0]) => "no one likes this"
Kata.Likes(new string[] {"Peter"}) => "Peter likes this"
Kata.Likes(new string[] {"Jacob", "Alex"}) => "Jacob and Alex like this"
Kata.Likes(new string[] {"Max", "John", "Mark"}) => "Max, John and Mark like this"
Kata.Likes(new string[] {"Alex", "Jacob", "Mark", "Max"}) => "Alex, Jacob and 2 others like this"
For 4 or more names, the number in and 2 others simply increases.
*/
namespace ListTask
{
    public static class Kata6
    {
        public static string Likes(string[] name)
        {
            var count = name.ToList().Count;
            String str;
            switch(count)
            {
                case 0:
                    str = "no one likes this";
                    break;
                case 1:
                    str = String.Format("{0} likes this", name[0]);
                    break;
                case 2:
                    str =  String.Format("{0} and {1} like this", name[0],name[1]);
                    break;
                default: 
                    str = count >3 ? String.Format("{0}, {1} and {2} others like this", name[0], name[1], count -2)
                        : String.Format("{0}, {1} and {2} like this", name[0], name[1], name[2]);
                    break;
            }
            return str;
        }
    }
}
