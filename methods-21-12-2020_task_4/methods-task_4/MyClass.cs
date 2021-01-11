using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace methods_task_4
{
    public static class MyClass
    {
        public static string GetLetterCount(this string s, char letter)
        {
            int cnt = s.Count(c => c == letter);
            string count = Convert.ToString(cnt);
            return count;
        }
    }
}