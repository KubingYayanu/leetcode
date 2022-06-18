using System.Collections.Generic;

namespace LeetCode.Library.Easy
{
    public class LongestCommonPrefixSolution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            var firstElement = strs[0];
            for (int i = 0; i < firstElement.Length; i++)
            {
                var c = firstElement[i];
                for (int j = 0; j < strs.Length; j++)
                {
                    var compareElement = strs[j];
                    if (compareElement.Length == i || c != compareElement[i])
                    {
                        return firstElement.Substring(0, i);
                    }
                }
            }

            return firstElement;
        }
    }
}