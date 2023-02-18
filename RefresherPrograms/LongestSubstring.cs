using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefresherPrograms
{
    internal class LongestSubstring
    {
        public int Longest(string s)
        {
            HashSet<char> set = new HashSet<char>();
            int maxLength = 0, start = -1, end = 0;

            for(end=0;end<s.Length;end++)
            {
                if (!set.Contains(s[end]))
                {
                    set.Add(s[end]);
                    maxLength = Math.Max(maxLength, end - start);
                }

                else
                {
                    set.Clear();
                    start = end;
                }
            }
            return maxLength;
        }
    }
}
