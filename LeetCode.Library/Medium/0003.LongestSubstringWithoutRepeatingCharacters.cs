using System;
using System.Collections.Generic;

namespace LeetCode.Library.Medium
{
    public class LongestSubstringWithoutRepeatingCharacters
    {
        public int LengthOfLongestSubstring(string s)
        {
            var set = new HashSet<char>();
            var maxLength = 0;
            var windowStart = 0;
            int windowEnd = 0;
            while (windowEnd < s.Length)
            {
                var target = s[windowEnd];
                if (!set.Contains(target))
                {
                    set.Add(target);
                    maxLength = Math.Max(maxLength, windowEnd - windowStart + 1);
                    windowEnd++;
                }
                else
                {
                    set.Remove(s[windowStart]);
                    windowStart++;
                }
            }

            return maxLength;
        }
    }
}