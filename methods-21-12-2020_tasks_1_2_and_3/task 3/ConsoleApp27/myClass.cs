using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp27
{
    public static class MyClass
    {
        
        public static string GetLetterCount(this string s, char letter)
        {
            int cnt = s.Count(c => c == letter);
            return Convert.ToString(cnt);
        }
    }
}
