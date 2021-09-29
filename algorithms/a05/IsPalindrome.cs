using System;
using System.Linq;

namespace a05
{
    public class IsPalindrome
    {  
        public static bool Check(string s)
        {
            return s.SequenceEqual(s.Reverse());
        }
    }
}
