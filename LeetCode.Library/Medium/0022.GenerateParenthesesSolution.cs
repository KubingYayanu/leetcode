using System.Collections.Generic;

namespace LeetCode.Library.Medium
{
    public class GenerateParenthesesSolution
    {
        public IList<string> GenerateParenthesis(int n)
        {
            var parenthesis = "()";
            var result = new List<string> { "" };
            var index = 0;
            while (index < n)
            {
                var temp = new List<string>();
                var count = result.Count;
                for (int i = 0; i < count; i++)
                {
                    var str = result[i];
                    var strLength = str.Length;
                    for (int j = 0; j < strLength + 1; j++)
                    {
                        var newStr = str.Insert(j, parenthesis);
                        if (!temp.Contains(newStr))
                        {
                            temp.Add(newStr);
                        }
                    }
                }
                result = temp;
                index++;
            }

            return result;
        }
    }
}