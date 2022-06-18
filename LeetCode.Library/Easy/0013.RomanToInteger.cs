using System.Collections.Generic;

namespace LeetCode.Library.Easy
{
    public class RomanToInteger
    {
        public int RomanToInt(string s)
        {
            var map = new Dictionary<char, int>
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };

            var result = 0;
            for (int i = 0; i < s.Length; i++)
            {
                var value = map[s[i]];
                if (i < s.Length - 1)
                {
                    var nextValue = map[s[i + 1]];
                    if (nextValue > value)
                    {
                        value = nextValue - value;
                        i += 1;
                    }
                }

                result += value;
            }

            return result;
        }
    }
}