namespace LeetCode.Library.Medium
{
    /// <summary>
    /// https://www.youtube.com/watch?v=XYQecbcd6_c
    /// </summary>
    public class LongestPalindromeSolution
    {
        public string LongestPalindrome(string s)
        {
            var max = string.Empty;
            for (int i = 0; i < s.Length; i++)
            {
                // odd
                max = GetSubstring(s, max, i, i);

                // even
                max = GetSubstring(s, max, i, i + 1);
            }

            return max;
        }

        private string GetSubstring(string s, string max, int leftPointer, int rightPointer)
        {
            while (leftPointer >= 0 && rightPointer < s.Length && s[leftPointer] == s[rightPointer])
            {
                if (rightPointer - leftPointer + 1 > max.Length)
                {
                    var str = s.Substring(leftPointer, rightPointer - leftPointer + 1);
                    max = str;
                }

                leftPointer--;
                rightPointer++;
            }

            return max;
        }
    }
}