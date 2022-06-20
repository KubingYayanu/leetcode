using System;
using System.Collections.Generic;

namespace LeetCode.Library.Medium
{
    public class LongestSubstringWithoutRepeatingCharacters
    {
        public int LengthOfLongestSubstring(string s)
        {
            var queue = new Queue<char>();
            var maxLength = 0;
            var windowStart = 0;
            int windowEnd = 0;
            while (windowEnd < s.Length)
            {
                var target = s[windowEnd];
                if (!queue.Contains(target))
                {
                    queue.Enqueue(target);
                    maxLength = Math.Max(maxLength, windowEnd - windowStart + 1);
                    windowEnd++;
                }
                else
                {
                    queue.Dequeue();
                    windowStart++;
                }
            }

            return maxLength;
        }
    }
}