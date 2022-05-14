using System.Collections.Generic;

namespace LeetCode.Library.Medium
{
    public class LetterCombinationsOfAPhoneNumber
    {
        private Dictionary<char, List<char>> _map = new Dictionary<char, List<char>>
        {
            { '2', new List<char> { 'a', 'b', 'c' } },
            { '3', new List<char> { 'd', 'e', 'f' } },
            { '4', new List<char> { 'g', 'h', 'i' } },
            { '5', new List<char> { 'j', 'k', 'l' } },
            { '6', new List<char> { 'm', 'n', 'o' } },
            { '7', new List<char> { 'p', 'q', 'r', 's' } },
            { '8', new List<char> { 't', 'u', 'v' } },
            { '9', new List<char> { 'w', 'x', 'y', 'z' } }
        };

        public IList<string> LetterCombinations(string digits)
        {
            var result = new List<string>();
            var temp = new List<string>();
            if (digits.Length == 0)
            {
                return result;
            }
            else if (digits.Length > 1)
            {
                var combinations = LetterCombinations(digits.Substring(1, digits.Length - 1));
                temp.AddRange(combinations);
            }
            else
            {
                temp.Add("");
            }

            for (int i = 0; i < temp.Count; i++)
            {
                var charSet = _map[digits[0]];
                for (int j = 0; j < charSet.Count; j++)
                {
                    result.Add($"{charSet[j]}{temp[i]}");
                }
            }

            return result;
        }
    }
}